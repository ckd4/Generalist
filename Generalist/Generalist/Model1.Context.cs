namespace Generalist
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GeneralistEntities3 : DbContext
    {
        private static GeneralistEntities3 _context;

        public static GeneralistEntities3 GetContext()
        {
            if (_context == null)
            {
                _context = new GeneralistEntities3();
            }

            return _context;
        }
        public GeneralistEntities3()
            : base("name=GeneralistEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Difficulty> Difficulty { get; set; }
        public virtual DbSet<Questions> Questions { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Users> Users { get; set; }
    }
}
