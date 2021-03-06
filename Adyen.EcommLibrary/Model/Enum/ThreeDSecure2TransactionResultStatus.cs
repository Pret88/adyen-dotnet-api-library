﻿using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Adyen.EcommLibrary.Model.Enum
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ThreeDSecure2TransactionResultStatus
    {

        /// <summary>
        /// Authentication / Account verification successful.
        /// </summary>
        [EnumMember(Value = "Y")]
        Y,

        /// <summary>
        /// Not Authenticated / account not verified. Transaction denied.
        /// </summary>
        [EnumMember(Value = "N")]
        N,

        /// <summary>
        /// Authentication / account verification could not be performed
        /// </summary>
        [EnumMember(Value = "U")]
        U,

        /// <summary>
        /// Authentication / verification was attempted but could not be verified.
        /// </summary>
        [EnumMember(Value = "A")]
        A,

        /// <summary>
        /// Challenge Required. Additional authentication is required using a Challenge
        /// </summary>
        [EnumMember(Value = "C")]
        C,

        /// <summary>
        /// Authentication / account verification rejected by the Issuer.
        /// </summary>
        [EnumMember(Value = "R")]
        R
    }
}
