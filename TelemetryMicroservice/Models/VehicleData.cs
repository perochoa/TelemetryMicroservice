using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TelemetryMicroservice.Models
{
    [Table("vehicle_data")]
    public class VehicleData
    {
        [Key]
        public long Id { get; set; }

        [Required]
        [MaxLength(50)]
        public required string VehicleID { get; set; }

        [Column("timestamp")]
        public DateTime TimeStamp { get; set; }

        // GPS Data
        public double? Latitude { get; set; }
        public double? Longitude { get; set; }
        public double? Altitude { get; set; }
        public double? GpsSpeed { get; set; }
        public double? Heading { get; set; }
        public double? Satellites { get; set; }
        public double? Hdop { get; set; }

        // OBD Data
        public double? EngineRpm { get; set; }
        public double? VehicleSpeed { get; set; }
        public double? EngineLoad { get; set; }
        public double? CoolantTemp { get; set; }
        public double? IntakeAirTemp { get; set; }
        public double? MafRate { get; set; }
        public double? ThrottlePosition { get; set; }
        public double? FuelLevel { get; set; }

        // JSON Column for DTC Codes
        [Column(TypeName ="jsonb")]
        public string? DtcCodes { get; set; }

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
