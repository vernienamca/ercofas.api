using System;
using System.Collections.Generic;
using System.Text;

namespace ERCOFAS.ApplicationCore.DTOs
{
    public class PageDTO
    {
        /// <summary>
        /// Gets or sets the page identifier.
        /// </summary>
        /// <value>
        /// The page identifier.
        /// </value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the page name.
        /// </summary>
        /// <value>
        /// The page name.
        /// </value>
        public string PageName { get; set; }
        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the url path.
        /// </summary>
        /// <value>
        /// The url path.
        /// </value>
        public string UrlPath { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether accessible by all.
        /// </summary>
        /// <value>
        ///   <c>true</c> if accessible by all; otherwise, <c>false</c>.
        /// </value>
        public bool? AccessibleByAll { get; set; }
        /// <summary>
        /// Gets or sets a value indicating whether is active.
        /// </summary>
        /// <value>
        ///   <c>true</c> if is active; otherwise, <c>false</c>.
        /// </value>
        public bool IsActive { get; set; }
    }
}
