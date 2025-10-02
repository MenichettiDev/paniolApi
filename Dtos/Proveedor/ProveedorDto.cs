namespace pyreApi.DTOs.Proveedor
{
    public class ProveedorDto
    {
        public int IdProveedor { get; set; }
        public string NombreProveedor { get; set; } = string.Empty;
        public string? Cuit { get; set; }
        public string? Telefono { get; set; }
        public string? Email { get; set; }
        public string? Direccion { get; set; }
        public bool Activo { get; set; }
        public int TotalReparaciones { get; set; }
        public int ReparacionesActivas { get; set; }
    }
}
