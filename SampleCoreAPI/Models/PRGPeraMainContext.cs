using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace SampleCoreAPI.Models
{
    public partial class PRGPeraMainContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public PRGPeraMainContext()
        {
        }

        public PRGPeraMainContext(DbContextOptions<PRGPeraMainContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }

        public virtual DbSet<AreaManager> AreaManager { get; set; }
        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<ClassStg> ClassStg { get; set; }
        public virtual DbSet<ClassUser> ClassUser { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<DepartmentUser> DepartmentUser { get; set; }
        public virtual DbSet<EmailAccount> EmailAccount { get; set; }
        public virtual DbSet<FinancialCompany> FinancialCompany { get; set; }
        public virtual DbSet<GenericAttribute> GenericAttribute { get; set; }
        public virtual DbSet<LocalAuth> LocalAuth { get; set; }
        public virtual DbSet<MessageTemplate> MessageTemplate { get; set; }
        public virtual DbSet<Module> Module { get; set; }
        public virtual DbSet<PrinterMap> PrinterMap { get; set; }
        public virtual DbSet<Profile> Profile { get; set; }
        public virtual DbSet<ProfileModuleMapping> ProfileModuleMapping { get; set; }
        public virtual DbSet<Province> Province { get; set; }
        public virtual DbSet<Region> Region { get; set; }
        public virtual DbSet<RegionManager> RegionManager { get; set; }
        public virtual DbSet<Setting> Setting { get; set; }
        public virtual DbSet<SkuMasterfile> SkuMasterfile { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<StoreArea> StoreArea { get; set; }
        public virtual DbSet<StoreType> StoreType { get; set; }
        public virtual DbSet<SubDepartment> SubDepartment { get; set; }
        public virtual DbSet<SubDepartmentUser> SubDepartmentUser { get; set; }
        public virtual DbSet<UserAccount> UserAccount { get; set; }
        public virtual DbSet<UserAccountStoreMapping> UserAccountStoreMapping { get; set; }
        public virtual DbSet<UserPassword> UserPassword { get; set; }
        public virtual DbSet<UserProfile> UserProfile { get; set; }
        public virtual DbSet<UserRole> UserRole { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }
        public virtual DbSet<VendorStg> VendorStg { get; set; }
        public virtual DbSet<VendorUser> VendorUser { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                          .UseLazyLoadingProxies()
                          .UseSqlServer(_configuration.GetConnectionString("PERAMainContext"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Class>(entity =>
            {
                entity.Property(e => e.ClassCode).HasColumnName("class_code");

                entity.Property(e => e.ClassCreated)
                    .IsRequired()
                    .HasColumnName("class_created")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ClassDtcreated)
                    .HasColumnName("class_dtcreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClassDtupdated)
                    .HasColumnName("class_dtupdated")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasColumnName("class_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClassStatus)
                    .IsRequired()
                    .HasColumnName("class_status")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClassUpdated)
                    .HasColumnName("class_updated")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DeptCode).HasColumnName("dept_code");

                entity.Property(e => e.SubdeptCode).HasColumnName("subdept_code");
            });

            modelBuilder.Entity<ClassStg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Class_STG", "stg");

                entity.Property(e => e.ClassCode).HasColumnName("class_code");

                entity.Property(e => e.ClassCreated)
                    .IsRequired()
                    .HasColumnName("class_created")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ClassDtcreated)
                    .HasColumnName("class_dtcreated")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClassDtupdated)
                    .HasColumnName("class_dtupdated")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClassName)
                    .IsRequired()
                    .HasColumnName("class_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ClassStatus)
                    .IsRequired()
                    .HasColumnName("class_status")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ClassUpdated)
                    .HasColumnName("class_updated")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.DeptCode).HasColumnName("dept_code");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.SubdeptCode).HasColumnName("subdept_code");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EmailAccount>(entity =>
            {
                entity.Property(e => e.DisplayName).HasMaxLength(255);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Host)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<FinancialCompany>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<GenericAttribute>(entity =>
            {
                entity.Property(e => e.CreatedOrUpdatedDateUtc).HasColumnName("CreatedOrUpdatedDateUTC");

                entity.Property(e => e.EntityGuid).HasMaxLength(100);

                entity.Property(e => e.Key)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.KeyGroup)
                    .IsRequired()
                    .HasMaxLength(400);

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<LocalAuth>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.HasOne(d => d.UserAccount)
                    .WithMany()
                    .HasForeignKey(d => d.UserAccountId)
                    .HasConstraintName("FKLocalAuth_UserAccount_Id");
            });

            modelBuilder.Entity<MessageTemplate>(entity =>
            {
                entity.Property(e => e.BccEmailAddresses).HasMaxLength(200);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Subject).HasMaxLength(1000);
            });

            modelBuilder.Entity<Module>(entity =>
            {
                entity.Property(e => e.Action).HasMaxLength(50);

                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.Controller).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.IconClass).HasMaxLength(50);

                entity.Property(e => e.Location).HasMaxLength(50);

                entity.Property(e => e.SystemName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<PrinterMap>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PrinterName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StoreCode)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Profile>(entity =>
            {
                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProfileModuleMapping>(entity =>
            {
                entity.ToTable("Profile_Module_Mapping");

                entity.HasOne(d => d.Module)
                    .WithMany(p => p.ProfileModuleMapping)
                    .HasForeignKey(d => d.ModuleId)
                    .HasConstraintName("FKProfile_Module_Mapping_ModuleId_Module_Id");

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.ProfileModuleMapping)
                    .HasForeignKey(d => d.ProfileId)
                    .HasConstraintName("FKProfile_Module_Mapping_ProfileId_Profile_Id");
            });

            modelBuilder.Entity<Province>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Province)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_Province_RegionId_Region_Id");
            });

            modelBuilder.Entity<Region>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.Value).IsRequired();
            });

            modelBuilder.Entity<SkuMasterfile>(entity =>
            {
                entity.HasIndex(e => e.DepartmentId);

                entity.Property(e => e.DcUom)
                    .HasColumnName("dc_uom")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.PsetCode)
                    .HasColumnName("pset_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Psku).HasColumnName("psku");

                entity.Property(e => e.Sku)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sqty)
                    .HasColumnName("sqty")
                    .HasColumnType("decimal(15, 2)");

                entity.Property(e => e.StrUom)
                    .HasColumnName("str_uom")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Upc)
                    .HasColumnName("UPC")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.Property(e => e.Address).IsRequired();

                entity.Property(e => e.BarterCode)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.BarterIpAddress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.IpAddress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.FinancialCompany)
                    .WithMany(p => p.Store)
                    .HasForeignKey(d => d.FinancialCompanyId)
                    .HasConstraintName("FK_Store_FinancialCompanyId_FinancialCompany_Id");

                entity.HasOne(d => d.Region)
                    .WithMany(p => p.Store)
                    .HasForeignKey(d => d.RegionId)
                    .HasConstraintName("FK_Store_RegionId_Region_Id");

                entity.HasOne(d => d.StoreArea)
                    .WithMany(p => p.Store)
                    .HasForeignKey(d => d.StoreAreaId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Store_StoreAreaId_StoreArea_Id");

                entity.HasOne(d => d.StoreType)
                    .WithMany(p => p.Store)
                    .HasForeignKey(d => d.StoreTypeId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Store_StoreTypeId_StoreArea_Id");
            });

            modelBuilder.Entity<StoreArea>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StoreType>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SubDepartment>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.SubDepartment)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_SubDepartment_DepartmentId_Department_Id");
            });

            modelBuilder.Entity<UserAccount>(entity =>
            {
                entity.Property(e => e.AdminComment).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.LastIpAddress)
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.SystemName).HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.UserAccount)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_UserAccount_ProfileId_Profile_Id");
            });

            modelBuilder.Entity<UserAccountStoreMapping>(entity =>
            {
                entity.ToTable("UserAccount_Store_Mapping");

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.UserAccountStoreMapping)
                    .HasForeignKey(d => d.StoreId)
                    .HasConstraintName("FKUserAccount_Store_Mapping_StoreId_Store_Id");

                entity.HasOne(d => d.UserAccount)
                    .WithMany(p => p.UserAccountStoreMapping)
                    .HasForeignKey(d => d.UserAccountId)
                    .HasConstraintName("FKUserAccount_Store_Mapping_UserAccountId_UserAccount_Id");
            });

            modelBuilder.Entity<UserPassword>(entity =>
            {
                entity.HasIndex(e => e.UserAccountId);

                entity.Property(e => e.Password).HasMaxLength(200);

                entity.Property(e => e.PasswordSalt).HasMaxLength(200);

                entity.HasOne(d => d.UserAccount)
                    .WithMany(p => p.UserPassword)
                    .HasForeignKey(d => d.UserAccountId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_UserPassword_UserAccountId_UserAccount_Id");
            });

            modelBuilder.Entity<UserProfile>(entity =>
            {
                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.Firstname)
                    .HasColumnName("firstname")
                    .HasMaxLength(100);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(50);

                entity.Property(e => e.Lastname)
                    .HasColumnName("lastname")
                    .HasMaxLength(50);

                entity.Property(e => e.Middlename)
                    .HasColumnName("middlename")
                    .HasMaxLength(50);

                entity.Property(e => e.UseraccountId).HasColumnName("useraccountId");
            });

            modelBuilder.Entity<UserRole>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.SystemName).HasMaxLength(50);
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.Property(e => e.LocationCode).HasColumnName("location_code");

                entity.Property(e => e.VendorCodePrimary).HasColumnName("vendor_code_primary");

                entity.Property(e => e.VendorCodeSecondary).HasColumnName("vendor_code_secondary");

                entity.Property(e => e.VendorCreateddate)
                    .HasColumnName("vendor_createddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.VendorFlagPrimay).HasColumnName("vendor_flag_primay");

                entity.Property(e => e.VendorFlagSecondary).HasColumnName("vendor_flag_secondary");

                entity.Property(e => e.VendorNamePrimary)
                    .IsRequired()
                    .HasColumnName("vendor_name_primary");

                entity.Property(e => e.VendorNameSecondary)
                    .IsRequired()
                    .HasColumnName("vendor_name_secondary");

                entity.Property(e => e.VendorPrimaryReturnFlg).HasColumnName("vendor_primary_return_flg");

                entity.Property(e => e.VendorSecondaryReturnFlg).HasColumnName("vendor_secondary_return_flg");

                entity.Property(e => e.VendorStatus).HasColumnName("vendor_status");

                entity.Property(e => e.VendorUpdateddate)
                    .HasColumnName("vendor_updateddate")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<VendorStg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Vendor_STG", "stg");

                entity.Property(e => e.LocationCode).HasColumnName("location_code");

                entity.Property(e => e.VendorCodePrimary).HasColumnName("vendor_code_primary");

                entity.Property(e => e.VendorCodeSecondary).HasColumnName("vendor_code_secondary");

                entity.Property(e => e.VendorCreateddate)
                    .HasColumnName("vendor_createddate")
                    .HasColumnType("datetime");

                entity.Property(e => e.VendorFlagPrimay).HasColumnName("vendor_flag_primay");

                entity.Property(e => e.VendorFlagSecondary).HasColumnName("vendor_flag_secondary");

                entity.Property(e => e.VendorNamePrimary)
                    .IsRequired()
                    .HasColumnName("vendor_name_primary")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorNameSecondary)
                    .IsRequired()
                    .HasColumnName("vendor_name_secondary")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.VendorPrimaryReturnFlg).HasColumnName("vendor_primary_return_flg");

                entity.Property(e => e.VendorSecondaryReturnFlg).HasColumnName("vendor_secondary_return_flg");

                entity.Property(e => e.VendorStatus).HasColumnName("vendor_status");

                entity.Property(e => e.VendorUpdateddate)
                    .HasColumnName("vendor_updateddate")
                    .HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
