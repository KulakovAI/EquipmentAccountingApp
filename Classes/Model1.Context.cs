﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EquipmentAccountingApp.Classes
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EquipmentAccountingEntities : DbContext
    {
        private static EquipmentAccountingEntities _context;
        public EquipmentAccountingEntities()
            : base("name=EquipmentAccountingEntities")
        {
        }

        public static EquipmentAccountingEntities GetContext()
        {
            if (_context == null)
                _context = new EquipmentAccountingEntities();
            return _context;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Equipment> Equipment { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TechnicalMaintenance> TechnicalMaintenance { get; set; }
        public virtual DbSet<TechnicalSpecifications> TechnicalSpecifications { get; set; }
        public virtual DbSet<TypeMaintenance> TypeMaintenance { get; set; }
        public virtual DbSet<Workshop> Workshop { get; set; }
    }
}
