// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Azure MySQL database linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureMySql")]
    [Rest.Serialization.JsonTransformation]
    public partial class AzureMySqlLinkedService : LinkedService
    {
        /// <summary>
        /// Initializes a new instance of the AzureMySqlLinkedService class.
        /// </summary>
        public AzureMySqlLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureMySqlLinkedService class.
        /// </summary>
        /// <param name="connectionString">The connection string.</param>
        /// <param name="connectVia">The integration runtime reference.</param>
        /// <param name="description">Linked service description.</param>
        /// <param name="encryptedCredential">The encrypted credential used for
        /// authentication. Credentials are encrypted using the integration
        /// runtime credential manager. Type: string (or Expression with
        /// resultType string).</param>
        public AzureMySqlLinkedService(SecureString connectionString, IntegrationRuntimeReference connectVia = default(IntegrationRuntimeReference), string description = default(string), object encryptedCredential = default(object))
            : base(connectVia, description)
        {
            ConnectionString = connectionString;
            EncryptedCredential = encryptedCredential;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the connection string.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.connectionString")]
        public SecureString ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public object EncryptedCredential { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (ConnectionString == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConnectionString");
            }
            if (ConnectionString != null)
            {
                ConnectionString.Validate();
            }
        }
    }
}
