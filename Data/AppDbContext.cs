using Microsoft.EntityFrameworkCore;


public class AppDbContext:DbContext{
    public AppDbContext(DbContextOptions<AppDbContext>options):base(options){}

    public DbSet<Student>Students{get;set;}
    public DbSet<Subject>Subjects{get;set;}
    public DbSet<Teacher>Teachers{get;set;}
    public DbSet<Grade>Grades{get;set;}
    public Db<User>Users{get;set;}
    public Db<Class>Classes{get;set;}
    public Db<Attendance>Attendances{get;set;}
    public Db<Announcement>Announcements{get;set;}


    protected overrid void OnModelCreating(ModelBuilder modelBuilder){
        base.OnModelCreating(modelBuilder)
   

    //student to class is many to one
        modelBuilder.Entity<Student>()
        .HasOne(s=>s.Classes)
        .WithMany(c=>c.Student)
        .HasForeignKey(c=>c.ClassId)
        .OnDelete(DeleteBehavior.Restrict);


    //Teacher to suubject one to many
    modelBuilder.Entity<Teacher>()
    .HasOne(t=>t.Teacher)
    .WithMany( s=>s.Subjects)
    .HasForeignKey(s => s.TeacherId)
    .OnDelete(DeleteBehavior.Restrict);



     modelBuilder.Entity<Grade>()
            .HasOne(g => g.Student)
            .WithMany(s => s.Grades)
            .HasForeignKey(g => g.StudentId);

        modelBuilder.Entity<Grade>()
            .HasOne(g => g.Subject)
            .WithMany(s => s.Grades)
            .HasForeignKey(g => g.SubjectId);

        // =========================
        // Student ↔ Attendance (One-to-Many)
        // =========================
        modelBuilder.Entity<Attendance>()
            .HasOne(a => a.Student)
            .WithMany(s => s.Attendances)
            .HasForeignKey(a => a.StudentId);

        // =========================
        // User ↔ Role (Enum-based)
        // =========================
        modelBuilder.Entity<User>()
            .HasIndex(u => u.Email)
            .IsUnique();


             modelBuilder.Entity<Announcement>()
            .HasOne(a => a.Class)
            .WithMany(c => c.Announcements)
            .HasForeignKey(a => a.ClassId)
            .OnDelete(DeleteBehavior.Cascade);

    }



    
}