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
    /// <para>The list folder result object</para>
    /// </summary>
    public sealed class ListFolderResult : enc.IEncodable<ListFolderResult>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListFolderResult" />
        /// class.</para>
        /// </summary>
        /// <param name="entries">The files and (direct) subfolders in the folder.</param>
        /// <param name="cursor">Pass the cursor into <see
        /// cref="Dropbox.Api.Files.Routes.FilesRoutes.ListFolderContinueAsync" /> to see
        /// what's changed in the folder since your previous query.</param>
        /// <param name="hasMore">If true, then there are more entries available. Pass the
        /// cursor to <see cref="Dropbox.Api.Files.Routes.FilesRoutes.ListFolderContinueAsync"
        /// /> to retrieve the rest.</param>
        public ListFolderResult(col.IEnumerable<Metadata> entries,
                                string cursor,
                                bool hasMore)
        {
            var entriesList = new col.List<Metadata>(entries ?? new Metadata[0]);

            if (entries == null)
            {
                throw new sys.ArgumentNullException("entries");
            }

            if (cursor == null)
            {
                throw new sys.ArgumentNullException("cursor");
            }

            this.Entries = entriesList;
            this.Cursor = cursor;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListFolderResult" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public ListFolderResult()
        {
        }

        /// <summary>
        /// <para>The files and (direct) subfolders in the folder.</para>
        /// </summary>
        public col.IList<Metadata> Entries { get; private set; }

        /// <summary>
        /// <para>Pass the cursor into <see
        /// cref="Dropbox.Api.Files.Routes.FilesRoutes.ListFolderContinueAsync" /> to see
        /// what's changed in the folder since your previous query.</para>
        /// </summary>
        public string Cursor { get; private set; }

        /// <summary>
        /// <para>If true, then there are more entries available. Pass the cursor to <see
        /// cref="Dropbox.Api.Files.Routes.FilesRoutes.ListFolderContinueAsync" /> to retrieve
        /// the rest.</para>
        /// </summary>
        public bool HasMore { get; private set; }

        #region IEncodable<ListFolderResult> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<ListFolderResult>.Encode(enc.IEncoder encoder)
        {
            using (var obj = encoder.AddObject())
            {
                obj.AddFieldObjectList<Metadata>("entries", this.Entries);
                obj.AddField<string>("cursor", this.Cursor);
                obj.AddField<bool>("has_more", this.HasMore);
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        ListFolderResult enc.IEncodable<ListFolderResult>.Decode(enc.IDecoder decoder)
        {
            using (var obj = decoder.GetObject())
            {
                this.Entries = new col.List<Metadata>(obj.GetFieldObjectList<Metadata>("entries"));
                this.Cursor = obj.GetField<string>("cursor");
                this.HasMore = obj.GetField<bool>("has_more");
            }

            return this;
        }

        #endregion
    }
}
