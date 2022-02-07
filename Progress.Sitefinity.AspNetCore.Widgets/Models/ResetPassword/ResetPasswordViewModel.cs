﻿using System.Collections.Generic;
using Progress.Sitefinity.AspNetCore.Models;

namespace Progress.Sitefinity.AspNetCore.Widgets.Models.ResetPassword
{
    /// <summary>
    /// The view model for the forgotten password widget.
    /// </summary>
    public class ResetPasswordViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResetPasswordViewModel"/> class.
        /// </summary>
        public ResetPasswordViewModel()
        {
            this.Labels = new ResetPasswordLabelsViewModel();
        }

        /// <summary>
        /// Gets or sets the reset user password handler path.
        /// </summary>
        public string ResetUserPasswordHandlerPath { get; set; }

        /// <summary>
        /// Gets or sets the change password handler path.
        /// </summary>
        public string SendResetPasswordEmailHandlerPath { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the membership provider settings require question and answer for reset/retrieval password functionality.
        /// </summary>
        /// <value>
        /// <c>true</c> if the membership provider requires question and answer; otherwise, <c>false</c>.
        /// </value>
        public bool RequiresQuestionAndAnswer { get; set; }

        /// <summary>
        /// Gets or sets the security question.
        /// </summary>
        public string SecurityQuestion { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether there is an error for the view model.
        /// </summary>
        public bool Error { get; set; }

        /// <summary>
        /// Gets or sets the login page link.
        /// </summary>
        public string LoginPageLink { get; set; }

        /// <summary>
        /// Gets or sets the labels.
        /// </summary>
        /// <value>
        /// The labels.
        /// </value>
        public ResetPasswordLabelsViewModel Labels { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the widget is in reset password mode.
        /// </summary>
        public bool IsResetPasswordRequest { get; set; }

        /// <summary>
        /// Gets or sets the reset password url.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Design", "CA1056:URI-like properties should not be strings", Justification = "Reviewed.")]
        public string ResetPasswordUrl { get; set; }

        /// <summary>
        /// Gets or sets the html form class attribute values.
        /// </summary>
        public string CssClass { get; set; }

        /// <summary>
        /// Gets or sets the attributes for the widget.
        /// </summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "CA2227:Collection properties should be read only", Justification = "Must be able to set in property editor.")]
        public IDictionary<string, IList<AttributeModel>> Attributes { get; set; }
    }
}
