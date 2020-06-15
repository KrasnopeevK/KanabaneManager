using KanbaneManager.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace KanbaneManager.DL.Repository
{
    public class KanbaneContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<TradePoint> TradePoint { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<State> States { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connection =
                @"Data Source=DESKTOP-AGJ0SL6\SQLEXPRESS;Database=KanbaneManager;Encrypt=False;Integrated Security=True;User ID=DESKTOP-AGJ0SL6\kiril";
            optionsBuilder.UseSqlServer(connection);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Role>(b => { b.Property(x => x.Id).ValueGeneratedOnAdd(); });
            modelBuilder.Entity<User>(b => { b.Property(x => x.Id).ValueGeneratedOnAdd(); });
            modelBuilder.Entity<Employee>(b =>
            {
                b.Property(x => x.Id).ValueGeneratedOnAdd();
                b.HasOne(x => x.Department).WithMany(x => x.Employees).HasForeignKey(x => x.DepartmentId);
            });
            modelBuilder.Entity<Department>(b => { b.Property(x => x.Id).ValueGeneratedOnAdd(); });
            modelBuilder.Entity<Car>(b => { b.Property(x => x.Id).ValueGeneratedOnAdd(); });
            modelBuilder.Entity<TradePoint>(b => { b.Property(x => x.Id).ValueGeneratedOnAdd(); });
            modelBuilder.Entity<Order>(b =>
            {
                b.Property(x => x.Id).ValueGeneratedOnAdd();
                b.HasOne(x => x.Car).WithMany(x => x.Orders).HasForeignKey(x => x.CarId);
                b.HasOne(x => x.Executor).WithMany(x => x.Orders).HasForeignKey(x => x.ExecutorId);
                b.HasOne(x => x.TradePoint).WithMany(x => x.Orders).HasForeignKey(x => x.TradePointId);
                b.HasOne(x => x.State).WithMany(x => x.Orders).HasForeignKey(x => x.StateId);

            });
            modelBuilder.Entity<State>(b => { b.Property(x => x.Id).ValueGeneratedOnAdd(); });


            base.OnModelCreating(modelBuilder);
        }
    }
}