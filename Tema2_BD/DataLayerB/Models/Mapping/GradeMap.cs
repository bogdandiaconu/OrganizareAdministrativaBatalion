using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DataLayerB.Models.Mapping
{
    public class GradeMap : EntityTypeConfiguration<Grade>
    {
        public GradeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID_Grad);

            // Properties
            this.Property(t => t.Nume)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Grade");
            this.Property(t => t.ID_Grad).HasColumnName("ID_Grad");
            this.Property(t => t.Nume).HasColumnName("Nume");
        }
    }
}
