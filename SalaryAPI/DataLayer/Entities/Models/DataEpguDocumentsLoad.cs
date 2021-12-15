using System;
using System.Collections.Generic;

#nullable disable

namespace DataLayer.Entities.Models
{
    public partial class DataEpguDocumentsLoad
    {
        public DataEpguDocumentsLoad()
        {
            DataEpguDocumentsResponses = new HashSet<DataEpguDocumentsResponse>();
        }

        public Guid Id { get; set; }
        public Guid SprSmevSystemAccessId { get; set; }
        public bool? TestMode { get; set; }
        public DateTime DateCreated { get; set; }
        public string DataServicesInfoId { get; set; }
        public Guid OriginalMessageId { get; set; }
        public string PortalMfcId { get; set; }
        public long EpguOrderId { get; set; }
        public string ServiceName { get; set; }
        public int Status { get; set; }
        public string StatusComment { get; set; }
        public int AttachmentCount { get; set; }
        public int ApplicantType { get; set; }
        public string ApplicantPhysFio { get; set; }
        public DateTime? ApplicantPhysBirthdate { get; set; }
        public string ApplicantPhysBirthplace { get; set; }
        public string ApplicantPhysSnils { get; set; }
        public string ApplicantPhysEmail { get; set; }
        public string ApplicantPhysRegAddress { get; set; }
        public string ApplicantPhysLivingAddress { get; set; }
        public int? ApplicantPhysIdentityType { get; set; }
        public string ApplicantPhysIdentitySeries { get; set; }
        public string ApplicantPhysIdentityNumber { get; set; }
        public DateTime? ApplicantPhysIdentityDate { get; set; }
        public string ApplicantPhysIdentityIssuer { get; set; }
        public string ApplicantPhysIdentityIssuerCode { get; set; }
        public string ApplicantLegalForm { get; set; }
        public string ApplicantLegalFullname { get; set; }
        public string ApplicantLegalName { get; set; }
        public string ApplicantLegalInn { get; set; }
        public string ApplicantLegalOgrn { get; set; }
        public string ApplicantLegalKpp { get; set; }
        public string ApplicantLegalAddress { get; set; }
        public string ApplicantLegalFactAddress { get; set; }
        public string ApplicantLegalPhone { get; set; }
        public string ApplicantLegalEmail { get; set; }
        public string ApplicantLegalChiefFio { get; set; }
        public bool AttachedToMfcData { get; set; }
        public int ElkStage { get; set; }
        public string ApplicantPhysPhone { get; set; }

        public virtual SprSmevSystemAccess SprSmevSystemAccess { get; set; }
        public virtual ICollection<DataEpguDocumentsResponse> DataEpguDocumentsResponses { get; set; }
    }
}
