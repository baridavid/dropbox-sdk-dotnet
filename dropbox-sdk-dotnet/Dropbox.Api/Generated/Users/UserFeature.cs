// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Users
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>A set of features that a Dropbox User account may have configured.</para>
    /// </summary>
    public class UserFeature
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<UserFeature> Encoder = new UserFeatureEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<UserFeature> Decoder = new UserFeatureDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UserFeature" /> class.</para>
        /// </summary>
        public UserFeature()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is PaperAsFiles</para>
        /// </summary>
        public bool IsPaperAsFiles
        {
            get
            {
                return this is PaperAsFiles;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a PaperAsFiles, or <c>null</c>.</para>
        /// </summary>
        public PaperAsFiles AsPaperAsFiles
        {
            get
            {
                return this as PaperAsFiles;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is FileLocking</para>
        /// </summary>
        public bool IsFileLocking
        {
            get
            {
                return this is FileLocking;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a FileLocking, or <c>null</c>.</para>
        /// </summary>
        public FileLocking AsFileLocking
        {
            get
            {
                return this as FileLocking;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Other</para>
        /// </summary>
        public bool IsOther
        {
            get
            {
                return this is Other;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Other, or <c>null</c>.</para>
        /// </summary>
        public Other AsOther
        {
            get
            {
                return this as Other;
            }
        }

        #region Encoder class

        /// <summary>
        /// <para>Encoder for  <see cref="UserFeature" />.</para>
        /// </summary>
        private class UserFeatureEncoder : enc.StructEncoder<UserFeature>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(UserFeature value, enc.IJsonWriter writer)
            {
                if (value is PaperAsFiles)
                {
                    WriteProperty(".tag", "paper_as_files", writer, enc.StringEncoder.Instance);
                    PaperAsFiles.Encoder.EncodeFields((PaperAsFiles)value, writer);
                    return;
                }
                if (value is FileLocking)
                {
                    WriteProperty(".tag", "file_locking", writer, enc.StringEncoder.Instance);
                    FileLocking.Encoder.EncodeFields((FileLocking)value, writer);
                    return;
                }
                if (value is Other)
                {
                    WriteProperty(".tag", "other", writer, enc.StringEncoder.Instance);
                    Other.Encoder.EncodeFields((Other)value, writer);
                    return;
                }
                throw new sys.InvalidOperationException();
            }
        }

        #endregion

        #region Decoder class

        /// <summary>
        /// <para>Decoder for  <see cref="UserFeature" />.</para>
        /// </summary>
        private class UserFeatureDecoder : enc.UnionDecoder<UserFeature>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="UserFeature" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override UserFeature Create()
            {
                return new UserFeature();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override UserFeature Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "paper_as_files":
                        return PaperAsFiles.Decoder.DecodeFields(reader);
                    case "file_locking":
                        return FileLocking.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>This feature contains information about how the user's Paper files are
        /// stored.</para>
        /// </summary>
        public sealed class PaperAsFiles : UserFeature
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<PaperAsFiles> Encoder = new PaperAsFilesEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<PaperAsFiles> Decoder = new PaperAsFilesDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="PaperAsFiles" />
            /// class.</para>
            /// </summary>
            private PaperAsFiles()
            {
            }

            /// <summary>
            /// <para>A singleton instance of PaperAsFiles</para>
            /// </summary>
            public static readonly PaperAsFiles Instance = new PaperAsFiles();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="PaperAsFiles" />.</para>
            /// </summary>
            private class PaperAsFilesEncoder : enc.StructEncoder<PaperAsFiles>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(PaperAsFiles value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="PaperAsFiles" />.</para>
            /// </summary>
            private class PaperAsFilesDecoder : enc.StructDecoder<PaperAsFiles>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="PaperAsFiles" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override PaperAsFiles Create()
                {
                    return PaperAsFiles.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>This feature allows users to lock files in order to restrict other users from
        /// editing them.</para>
        /// </summary>
        public sealed class FileLocking : UserFeature
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<FileLocking> Encoder = new FileLockingEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<FileLocking> Decoder = new FileLockingDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="FileLocking" />
            /// class.</para>
            /// </summary>
            private FileLocking()
            {
            }

            /// <summary>
            /// <para>A singleton instance of FileLocking</para>
            /// </summary>
            public static readonly FileLocking Instance = new FileLocking();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="FileLocking" />.</para>
            /// </summary>
            private class FileLockingEncoder : enc.StructEncoder<FileLocking>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(FileLocking value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="FileLocking" />.</para>
            /// </summary>
            private class FileLockingDecoder : enc.StructDecoder<FileLocking>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="FileLocking" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override FileLocking Create()
                {
                    return FileLocking.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : UserFeature
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Other> Encoder = new OtherEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Other> Decoder = new OtherDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Other" /> class.</para>
            /// </summary>
            private Other()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Other</para>
            /// </summary>
            public static readonly Other Instance = new Other();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherEncoder : enc.StructEncoder<Other>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Other value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Other" />.</para>
            /// </summary>
            private class OtherDecoder : enc.StructDecoder<Other>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Other" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Other Create()
                {
                    return Other.Instance;
                }

            }

            #endregion
        }
    }
}
