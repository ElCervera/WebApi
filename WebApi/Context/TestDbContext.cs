using Microsoft.EntityFrameworkCore;
using WebApi.Model;

namespace WebApi.Context
{
    public class TestDbContext : DbContext
    {
        public TestDbContext(DbContextOptions<TestDbContext> options) : base(options)
        {
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Mechanic> Mechanics { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<AppointmentService> AppointmentServices { get; set; }
        public DbSet<AppointmentPart> AppointmentParts { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseInventory> PurchaseInventories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<MaintenanceHistory> MaintenanceHistories { get; set; }
        public DbSet<Inventory> Inventories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Especificación de tipo de columna para propiedades decimal
            modelBuilder.Entity<Inventory>()
                .Property(i => i.Price)
                .HasColumnType("decimal(10, 2)");

            modelBuilder.Entity<Part>()
                .Property(p => p.Price)
                .HasColumnType("decimal(10, 2)");

            modelBuilder.Entity<Payment>()
                .Property(p => p.Amount)
                .HasColumnType("decimal(10, 2)");

            modelBuilder.Entity<Purchase>()
                .Property(p => p.Total)
                .HasColumnType("decimal(10, 2)");

            modelBuilder.Entity<PurchaseInventory>()
                .Property(pi => pi.UnitPrice)
                .HasColumnType("decimal(10, 2)");

            modelBuilder.Entity<Service>()
                .Property(s => s.Price)
                .HasColumnType("decimal(10, 2)");

            // Configuración de relaciones
            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Client)
                .WithMany(c => c.Appointments)
                .HasForeignKey(a => a.ClientId);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Vehicle)
                .WithMany(v => v.Appointments)
                .HasForeignKey(a => a.VehicleId);

            modelBuilder.Entity<Appointment>()
                .HasOne(a => a.Mechanic)
                .WithMany(m => m.Appointments)
                .HasForeignKey(a => a.MechanicId);

            modelBuilder.Entity<AppointmentService>()
                .HasKey(aps => new { aps.AppointmentId, aps.ServiceId });

            modelBuilder.Entity<AppointmentService>()
                .HasOne(aps => aps.Appointment)
                .WithMany(a => a.AppointmentServices)
                .HasForeignKey(aps => aps.AppointmentId);

            modelBuilder.Entity<AppointmentService>()
                .HasOne(aps => aps.Service)
                .WithMany(s => s.AppointmentServices)
                .HasForeignKey(aps => aps.ServiceId);

            modelBuilder.Entity<AppointmentPart>()
                .HasKey(ap => new { ap.AppointmentId, ap.PartId });

            modelBuilder.Entity<AppointmentPart>()
                .HasOne(ap => ap.Appointment)
                .WithMany(a => a.AppointmentParts)
                .HasForeignKey(ap => ap.AppointmentId);

            modelBuilder.Entity<AppointmentPart>()
                .HasOne(ap => ap.Part)
                .WithMany(p => p.AppointmentParts)
                .HasForeignKey(ap => ap.PartId);

            modelBuilder.Entity<Service>()
                .HasOne(s => s.ServiceType)
                .WithMany(st => st.Services)
                .HasForeignKey(s => s.ServiceTypeId);
        }
    }
}
