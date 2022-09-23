// General
global using Microsoft.AspNetCore.Mvc;
global using System.Collections.Generic;
global using System.Threading.Tasks;
global using System.Text;
global using System.ComponentModel.DataAnnotations;
global using API.Interfaces;
global using API.Services;
global using Microsoft.IdentityModel.Tokens;
global using System.IdentityModel.Tokens.Jwt;
global using System.Security.Claims;
global using Microsoft.AspNetCore.Authorization;
global using Microsoft.AspNetCore.Authentication.JwtBearer;
global using API.Extensions;
// Core
global using Microsoft.EntityFrameworkCore;

// Entities
global using API.Entities;
global using API.Data;

// DTO
global using API.DTO;

// Security
global using System.Security.Cryptography;