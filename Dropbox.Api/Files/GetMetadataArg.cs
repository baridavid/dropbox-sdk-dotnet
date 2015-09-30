// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The get metadata arg object</para>
    /// </summary>
    public sealed class GetMetadataArg : enc.IEncodable<GetMetadataArg>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetMetadataArg" /> class.</para>
        /// </summary>
        /// <param name="path">The path of a file or folder on Dropbox</param>
        public GetMetadataArg(string path)
        {
            if (path == null)
            {
                throw new sys.ArgumentNullException("path");
            }
            else if (!re.Regex.IsMatch(path, @"((/|id:).*)|(rev:[0-9a-f]{9,})"))
            {
                throw new sys.ArgumentOutOfRangeException("path");
            }

            this.Path = path;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetMetadataArg" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public GetMetadataArg()
        {
        }

        /// <summary>
        /// <para>The path of a file or folder on Dropbox</para>
        /// </summary>
        public string Path { get; private set; }

        #region IEncodable<GetMetadataArg> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<GetMetadataArg>.Encode(enc.IEncoder encoder)
        {
            using (var obj = encoder.AddObject())
            {
                obj.AddField<string>("path", this.Path);
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        GetMetadataArg enc.IEncodable<GetMetadataArg>.Decode(enc.IDecoder decoder)
        {
            using (var obj = decoder.GetObject())
            {
                this.Path = obj.GetField<string>("path");
            }

            return this;
        }

        #endregion
    }
}
