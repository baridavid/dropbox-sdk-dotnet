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
    /// <para>The preview error object</para>
    /// </summary>
    public class PreviewError : enc.IEncodable<PreviewError>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="PreviewError" /> class.</para>
        /// </summary>
        public PreviewError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Path</para>
        /// </summary>
        public bool IsPath
        {
            get
            {
                return this is Path;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Path, or <c>null</c>.</para>
        /// </summary>
        public Path AsPath
        {
            get
            {
                return this as Path;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is InProgress</para>
        /// </summary>
        public bool IsInProgress
        {
            get
            {
                return this is InProgress;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a InProgress, or <c>null</c>.</para>
        /// </summary>
        public InProgress AsInProgress
        {
            get
            {
                return this as InProgress;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is UnsupportedExtension</para>
        /// </summary>
        public bool IsUnsupportedExtension
        {
            get
            {
                return this is UnsupportedExtension;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a UnsupportedExtension, or <c>null</c>.</para>
        /// </summary>
        public UnsupportedExtension AsUnsupportedExtension
        {
            get
            {
                return this as UnsupportedExtension;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is UnsupportedContent</para>
        /// </summary>
        public bool IsUnsupportedContent
        {
            get
            {
                return this is UnsupportedContent;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a UnsupportedContent, or <c>null</c>.</para>
        /// </summary>
        public UnsupportedContent AsUnsupportedContent
        {
            get
            {
                return this as UnsupportedContent;
            }
        }

        #region IEncodable<PreviewError> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<PreviewError>.Encode(enc.IEncoder encoder)
        {
            if (this.IsPath)
            {
                ((enc.IEncodable<Path>)this).Encode(encoder);
            }
            else if (this.IsInProgress)
            {
                ((enc.IEncodable<InProgress>)this).Encode(encoder);
            }
            else if (this.IsUnsupportedExtension)
            {
                ((enc.IEncodable<UnsupportedExtension>)this).Encode(encoder);
            }
            else if (this.IsUnsupportedContent)
            {
                ((enc.IEncodable<UnsupportedContent>)this).Encode(encoder);
            }
            else
            {
                throw new sys.InvalidOperationException();
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        PreviewError enc.IEncodable<PreviewError>.Decode(enc.IDecoder decoder)
        {
            switch (decoder.GetUnionName())
            {
            case "path":
                using (var obj = decoder.GetObject())
                {
                    return new Path(obj.GetFieldObject<LookupError>("path"));
                }
            case "in_progress":
                return InProgress.Instance;
            case "unsupported_extension":
                return UnsupportedExtension.Instance;
            case "unsupported_content":
                return UnsupportedContent.Instance;
            default:
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        /// <summary>
        /// <para>An error occurs when downloading metadata for the file.</para>
        /// </summary>
        public sealed class Path : PreviewError, enc.IEncodable<Path>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Path" /> class.</para>
            /// </summary>
            /// <param name="value">The value</param>
            public Path(LookupError value)
            {
                this.Value = value;
            }

            /// <summary>
            /// <para>Gets the value of this instance.</para>
            /// </summary>
            public LookupError Value { get; private set; }

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            void enc.IEncodable<Path>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "path");
                    obj.AddField("path", this.Value);
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            Path enc.IEncodable<Path>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>This preview generation is still in progress and the file is not ready  for
        /// preview yet.</para>
        /// </summary>
        public sealed class InProgress : PreviewError, enc.IEncodable<InProgress>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="InProgress" /> class.</para>
            /// </summary>
            private InProgress()
            {
            }

            /// <summary>
            /// <para>A singleton instance of InProgress</para>
            /// </summary>
            public static readonly InProgress Instance = new InProgress();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<InProgress>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "in_progress");
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            InProgress enc.IEncodable<InProgress>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>The file extension is not supported preview generation.</para>
        /// </summary>
        public sealed class UnsupportedExtension : PreviewError, enc.IEncodable<UnsupportedExtension>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="UnsupportedExtension" />
            /// class.</para>
            /// </summary>
            private UnsupportedExtension()
            {
            }

            /// <summary>
            /// <para>A singleton instance of UnsupportedExtension</para>
            /// </summary>
            public static readonly UnsupportedExtension Instance = new UnsupportedExtension();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<UnsupportedExtension>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "unsupported_extension");
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            UnsupportedExtension enc.IEncodable<UnsupportedExtension>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>The file content is not supported for preview generation.</para>
        /// </summary>
        public sealed class UnsupportedContent : PreviewError, enc.IEncodable<UnsupportedContent>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="UnsupportedContent" />
            /// class.</para>
            /// </summary>
            private UnsupportedContent()
            {
            }

            /// <summary>
            /// <para>A singleton instance of UnsupportedContent</para>
            /// </summary>
            public static readonly UnsupportedContent Instance = new UnsupportedContent();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<UnsupportedContent>.Encode(enc.IEncoder encoder)
            {
                using (var obj = encoder.AddObject())
                {
                    obj.AddField(".tag", "unsupported_content");
                }
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            UnsupportedContent enc.IEncodable<UnsupportedContent>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }
    }
}
