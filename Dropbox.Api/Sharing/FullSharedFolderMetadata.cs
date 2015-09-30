// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Sharing
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The full metadata for the shared folder which includes user and group
    /// membership.</para>
    /// </summary>
    /// <seealso cref="SharedFolderMetadata" />
    public sealed class FullSharedFolderMetadata : SharedFolderMetadata, enc.IEncodable<FullSharedFolderMetadata>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FullSharedFolderMetadata" />
        /// class.</para>
        /// </summary>
        /// <param name="name">The name of the this shared folder.</param>
        /// <param name="id">The ID of the shared folder.</param>
        /// <param name="accessType">Who can access this shared folder.</param>
        /// <param name="sharedLinkPolicy">Who links can be shared with.</param>
        /// <param name="membership">The list of user members of the shared folder.</param>
        /// <param name="groups">The list of group members of the shared folder.</param>
        /// <param name="pathLower">The lower-cased full path of this shared folder. Absent for
        /// unmounted folders.</param>
        public FullSharedFolderMetadata(string name,
                                        string id,
                                        AccessType accessType,
                                        SharedLinkPolicy sharedLinkPolicy,
                                        col.IEnumerable<UserMembershipInfo> membership,
                                        col.IEnumerable<GroupMembershipInfo> groups,
                                        string pathLower = null)
            : base(name, id, accessType, sharedLinkPolicy, pathLower)
        {
            var membershipList = new col.List<UserMembershipInfo>(membership ?? new UserMembershipInfo[0]);

            if (membership == null)
            {
                throw new sys.ArgumentNullException("membership");
            }

            var groupsList = new col.List<GroupMembershipInfo>(groups ?? new GroupMembershipInfo[0]);

            if (groups == null)
            {
                throw new sys.ArgumentNullException("groups");
            }

            this.Membership = membershipList;
            this.Groups = groupsList;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FullSharedFolderMetadata" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public FullSharedFolderMetadata()
        {
        }

        /// <summary>
        /// <para>The list of user members of the shared folder.</para>
        /// </summary>
        public col.IList<UserMembershipInfo> Membership { get; private set; }

        /// <summary>
        /// <para>The list of group members of the shared folder.</para>
        /// </summary>
        public col.IList<GroupMembershipInfo> Groups { get; private set; }

        #region IEncodable<FullSharedFolderMetadata> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<FullSharedFolderMetadata>.Encode(enc.IEncoder encoder)
        {
            using (var obj = encoder.AddObject())
            {
                obj.AddField<string>(".tag", "full");
                obj.AddField<string>("name", this.Name);
                obj.AddField<string>("id", this.Id);
                obj.AddFieldObject<AccessType>("access_type", this.AccessType);
                obj.AddFieldObject<SharedLinkPolicy>("shared_link_policy", this.SharedLinkPolicy);
                obj.AddFieldObjectList<UserMembershipInfo>("membership", this.Membership);
                obj.AddFieldObjectList<GroupMembershipInfo>("groups", this.Groups);
                if (this.PathLower != null)
                {
                    obj.AddField<string>("path_lower", this.PathLower);
                }
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        FullSharedFolderMetadata enc.IEncodable<FullSharedFolderMetadata>.Decode(enc.IDecoder decoder)
        {
            using (var obj = decoder.GetObject())
            {
                this.Name = obj.GetField<string>("name");
                this.Id = obj.GetField<string>("id");
                this.AccessType = obj.GetFieldObject<AccessType>("access_type");
                this.SharedLinkPolicy = obj.GetFieldObject<SharedLinkPolicy>("shared_link_policy");
                this.Membership = new col.List<UserMembershipInfo>(obj.GetFieldObjectList<UserMembershipInfo>("membership"));
                this.Groups = new col.List<GroupMembershipInfo>(obj.GetFieldObjectList<GroupMembershipInfo>("groups"));
                if (obj.HasField("path_lower"))
                {
                    this.PathLower = obj.GetField<string>("path_lower");
                }
            }

            return this;
        }

        #endregion
    }
}
