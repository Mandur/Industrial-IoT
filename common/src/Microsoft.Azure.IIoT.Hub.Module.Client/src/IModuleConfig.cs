// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
//  Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.Azure.IIoT.Module.Framework.Client {

    /// <summary>
    /// Module configuration
    /// </summary>
    public interface IModuleConfig {

        /// <summary>
        /// IoTEdgeHub connection string
        /// </summary>
        string EdgeHubConnectionString { get; }

        /// <summary>
        /// Bypass cert validation with hub
        /// </summary>
        bool BypassCertVerification { get; }

        /// <summary>
        /// false (default) use Edge Hub
        /// true use IoT Hub directly
        /// </summary>
        bool BypassEdgeHub { get; }
        
        /// <summary>
        /// IoT Device connection string
        /// </summary>
        string IoTHubConnectionString { get; }

        /// <summary>
        /// Enable metrics collection
        /// </summary>
        bool EnableMetrics { get; }

        /// <summary>
        /// Transports to use
        /// </summary>
        TransportOption Transport { get; }
    }
}
