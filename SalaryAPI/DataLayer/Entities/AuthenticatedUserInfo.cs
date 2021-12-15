using System;

namespace DataLayer.Entities
{
    public class AuthenticatedUserInfo
    {
        /// <summary>
        /// Идентификатор
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// ФИО
        /// </summary>
        public string Fio { get; set; }
        /// <summary>
        /// Информация об офисе
        /// </summary>
        public Office OfficeInfo { get; set; }

        /// <summary>
        /// Идентификатор роли сотрудника
        /// </summary>
        public Guid RoleId { get; set; }

        public class Office 
        {
            /// <summary>
            /// Идентификатор филиала в котором работает сотрудник
            /// </summary>
            public Guid OfficeId { get; set; }
            /// <summary>
            /// Идентификатор должности сотрудника
            /// </summary>
            public int? JobPositionId { get; set; }
            /// <summary>
            /// Мнемоника МФЦ
            /// </summary>
            public string OfficeMnemo { get; set; }
        }

    }

    

}
