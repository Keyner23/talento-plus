using System.ComponentModel.DataAnnotations;

namespace TalentoPlus.Core.Entities;

public class Empleado
{
    [Key] 
    public string? Documento { get; set; }
    public string? Nombre { get; set; }
    public string? Apellidos { get; set; }
    public string? FechaNacimiento { get; set; }
    public string? Direccion { get; set; }
    public string? Telefono { get; set; }
    public string? Email { get; set; }
    public string? Cargo { get; set; }
    public string? Salario { get; set; }
    public string? FechaIngreso { get; set; }
    public string? Estado { get; set; }
    public string? NivelEducativo { get; set; }
    public string? PerfilProfesional { get; set; }
    public string? Departamento { get; set; }
}