﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using Adyen.EcommLibrary.Constants;
using Adyen.EcommLibrary.Model.ApplicationInformation;
using Newtonsoft.Json;

namespace Adyen.EcommLibrary.Model.Modification
{
    [DataContract]
    public class CancelRequest: AbstractModificationRequest
    {
        public CancelRequest()
        {
             if(ApplicationInfo==null)
                ApplicationInfo = new ApplicationInfo();
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CancelRequest {\n");
            sb.Append(base.ToString());
            sb.Append("}");
            return sb.ToString();
        }
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }
    }
}
