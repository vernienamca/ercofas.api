using System;
using System.Collections.Generic;
using System.Text;

namespace ERCOFAS.ApplicationCore.DTOs
{
    public class ManageRoleDTO
    {
        /// <summary>
        /// Gets or sets the page access identifier.
        /// </summary>
        /// <value>
        /// The page access identifier.
        /// </value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the page identifier.
        /// </summary>
        /// <value>
        /// The page identifier.
        /// </value>
        public int PageId { get; set; }
        /// <summary>
        /// Gets or sets the role identifier.
        /// </summary>
        /// <value>
        /// The role identifier.
        /// </value>
        public int RoleId { get; set; }
        /// <summary>
        /// Gets or sets the role name.
        /// </summary>
        /// <value>
        /// The role name.
        /// </value>
        public string RoleName { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether can create.
        /// </summary>
        /// <value>
        ///   <c>true</c> if can create; otherwise, <c>false</c>.
        /// </value>
        public bool CanCreate { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether can read.
        /// </summary>
        /// <value>
        ///   <c>true</c> if can read; otherwise, <c>false</c>.
        /// </value>
        public bool CanRead { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether can update.
        /// </summary>
        /// <value>
        ///   <c>true</c> if can update; otherwise, <c>false</c>.
        /// </value>
        public bool CanUpdate { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether can delete.
        /// </summary>
        /// <value>
        ///   <c>true</c> if can delete; otherwise, <c>false</c>.
        /// </value>
        public bool CanDelete { get; set; }
        /// <summary>
        /// Gets or sets the created by.
        /// </summary>
        /// <value>
        /// The created by.
        /// </value>
        public int CreatedBy { get; set; }
        /// <summary>
        /// Gets or sets the date created.
        /// </summary>
        /// <value>
        /// The date created.
        /// </value>
        public DateTime DateCreated { get; set; }
        /// <summary>
        /// Gets or sets the updated by.
        /// </summary>
        /// <value>
        /// The updated by.
        /// </value>
        public int? UpdatedBy { get; set; }
        /// <summary>
        /// Gets or sets the date updated.
        /// </summary>
        /// <value>
        /// The date updated.
        /// </value>
        public DateTime? DateUpdated { get; set; }
    }
}
