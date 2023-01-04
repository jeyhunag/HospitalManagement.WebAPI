using HospitalManagement.WebAPI.Data;
using HospitalMenegment.DAL.Interfaces;
using HospitalMenegment.DAL.Repositories;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString"));
    opts.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);

});
builder.Services.AddScoped<IPatientRepostory, PatientRepository>();
builder.Services.AddScoped<INurseRepostory, NurseRepostory>();
builder.Services.AddScoped<IMedicineRepostory, MedicineRepostory>();
builder.Services.AddScoped<IHospitalRepostory, HospitalRepostory>();
builder.Services.AddScoped<IDoctorRepostory, DoctorRepostory>();
builder.Services.AddScoped<IAppointmentRepostroy, AppointmentRepostory>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
