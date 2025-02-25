// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.BotService.Support
{

    public partial struct ChannelName :
        System.IEquatable<ChannelName>
    {
        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.ChannelName DirectLineChannel = @"DirectLineChannel";

        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.ChannelName EmailChannel = @"EmailChannel";

        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.ChannelName FacebookChannel = @"FacebookChannel";

        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.ChannelName KikChannel = @"KikChannel";

        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.ChannelName MSTeamsChannel = @"MsTeamsChannel";

        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.ChannelName SkypeChannel = @"SkypeChannel";

        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.ChannelName SlackChannel = @"SlackChannel";

        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.ChannelName SmsChannel = @"SmsChannel";

        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.ChannelName TelegramChannel = @"TelegramChannel";

        public static Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.ChannelName WebChatChannel = @"WebChatChannel";

        /// <summary>the value for an instance of the <see cref="ChannelName" /> Enum.</summary>
        private string _value { get; set; }

        /// <summary>Creates an instance of the <see cref="ChannelName"/> Enum class.</summary>
        /// <param name="underlyingValue">the value to create an instance for.</param>
        private ChannelName(string underlyingValue)
        {
            this._value = underlyingValue;
        }

        /// <summary>Conversion from arbitrary object to ChannelName</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ChannelName" />.</param>
        internal static object CreateFrom(object value)
        {
            return new ChannelName(global::System.Convert.ToString(value));
        }

        /// <summary>Compares values of enum type ChannelName</summary>
        /// <param name="e">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public bool Equals(Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.ChannelName e)
        {
            return _value.Equals(e._value);
        }

        /// <summary>Compares values of enum type ChannelName (override for Object)</summary>
        /// <param name="obj">the value to compare against this instance.</param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public override bool Equals(object obj)
        {
            return obj is ChannelName && Equals((ChannelName)obj);
        }

        /// <summary>Returns hashCode for enum ChannelName</summary>
        /// <returns>The hashCode of the value</returns>
        public override int GetHashCode()
        {
            return this._value.GetHashCode();
        }

        /// <summary>Returns string representation for ChannelName</summary>
        /// <returns>A string for this value.</returns>
        public override string ToString()
        {
            return this._value;
        }

        /// <summary>Implicit operator to convert string to ChannelName</summary>
        /// <param name="value">the value to convert to an instance of <see cref="ChannelName" />.</param>

        public static implicit operator ChannelName(string value)
        {
            return new ChannelName(value);
        }

        /// <summary>Implicit operator to convert ChannelName to string</summary>
        /// <param name="e">the value to convert to an instance of <see cref="ChannelName" />.</param>

        public static implicit operator string(Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.ChannelName e)
        {
            return e._value;
        }

        /// <summary>Overriding != operator for enum ChannelName</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are not equal to the same value</returns>
        public static bool operator !=(Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.ChannelName e1, Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.ChannelName e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>Overriding == operator for enum ChannelName</summary>
        /// <param name="e1">the value to compare against <paramref name="e2" /></param>
        /// <param name="e2">the value to compare against <paramref name="e1" /></param>
        /// <returns><c>true</c> if the two instances are equal to the same value</returns>
        public static bool operator ==(Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.ChannelName e1, Microsoft.Azure.PowerShell.Cmdlets.BotService.Support.ChannelName e2)
        {
            return e2.Equals(e1);
        }
    }
}