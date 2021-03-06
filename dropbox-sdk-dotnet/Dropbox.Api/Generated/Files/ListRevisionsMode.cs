// <auto-generated>
// Auto-generated by StoneAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Stone;

    /// <summary>
    /// <para>The list revisions mode object</para>
    /// </summary>
    public class ListRevisionsMode
    {
        #pragma warning disable 108

        /// <summary>
        /// <para>The encoder instance.</para>
        /// </summary>
        internal static enc.StructEncoder<ListRevisionsMode> Encoder = new ListRevisionsModeEncoder();

        /// <summary>
        /// <para>The decoder instance.</para>
        /// </summary>
        internal static enc.StructDecoder<ListRevisionsMode> Decoder = new ListRevisionsModeDecoder();

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListRevisionsMode" />
        /// class.</para>
        /// </summary>
        public ListRevisionsMode()
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
        /// <para>Gets a value indicating whether this instance is Id</para>
        /// </summary>
        public bool IsId
        {
            get
            {
                return this is Id;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Id, or <c>null</c>.</para>
        /// </summary>
        public Id AsId
        {
            get
            {
                return this as Id;
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
        /// <para>Encoder for  <see cref="ListRevisionsMode" />.</para>
        /// </summary>
        private class ListRevisionsModeEncoder : enc.StructEncoder<ListRevisionsMode>
        {
            /// <summary>
            /// <para>Encode fields of given value.</para>
            /// </summary>
            /// <param name="value">The value.</param>
            /// <param name="writer">The writer.</param>
            public override void EncodeFields(ListRevisionsMode value, enc.IJsonWriter writer)
            {
                if (value is Path)
                {
                    WriteProperty(".tag", "path", writer, enc.StringEncoder.Instance);
                    Path.Encoder.EncodeFields((Path)value, writer);
                    return;
                }
                if (value is Id)
                {
                    WriteProperty(".tag", "id", writer, enc.StringEncoder.Instance);
                    Id.Encoder.EncodeFields((Id)value, writer);
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
        /// <para>Decoder for  <see cref="ListRevisionsMode" />.</para>
        /// </summary>
        private class ListRevisionsModeDecoder : enc.UnionDecoder<ListRevisionsMode>
        {
            /// <summary>
            /// <para>Create a new instance of type <see cref="ListRevisionsMode" />.</para>
            /// </summary>
            /// <returns>The struct instance.</returns>
            protected override ListRevisionsMode Create()
            {
                return new ListRevisionsMode();
            }

            /// <summary>
            /// <para>Decode based on given tag.</para>
            /// </summary>
            /// <param name="tag">The tag.</param>
            /// <param name="reader">The json reader.</param>
            /// <returns>The decoded object.</returns>
            protected override ListRevisionsMode Decode(string tag, enc.IJsonReader reader)
            {
                switch (tag)
                {
                    case "path":
                        return Path.Decoder.DecodeFields(reader);
                    case "id":
                        return Id.Decoder.DecodeFields(reader);
                    default:
                        return Other.Decoder.DecodeFields(reader);
                }
            }
        }

        #endregion

        /// <summary>
        /// <para>Returns revisions with the same file path as identified by the latest file
        /// entry at the given file path or id.</para>
        /// </summary>
        public sealed class Path : ListRevisionsMode
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Path> Encoder = new PathEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Path> Decoder = new PathDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Path" /> class.</para>
            /// </summary>
            private Path()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Path</para>
            /// </summary>
            public static readonly Path Instance = new Path();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Path" />.</para>
            /// </summary>
            private class PathEncoder : enc.StructEncoder<Path>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Path value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Path" />.</para>
            /// </summary>
            private class PathDecoder : enc.StructDecoder<Path>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Path" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Path Create()
                {
                    return Path.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>Returns revisions with the same file id as identified by the latest file
        /// entry at the given file path or id.</para>
        /// </summary>
        public sealed class Id : ListRevisionsMode
        {
            #pragma warning disable 108

            /// <summary>
            /// <para>The encoder instance.</para>
            /// </summary>
            internal static enc.StructEncoder<Id> Encoder = new IdEncoder();

            /// <summary>
            /// <para>The decoder instance.</para>
            /// </summary>
            internal static enc.StructDecoder<Id> Decoder = new IdDecoder();

            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Id" /> class.</para>
            /// </summary>
            private Id()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Id</para>
            /// </summary>
            public static readonly Id Instance = new Id();

            #region Encoder class

            /// <summary>
            /// <para>Encoder for  <see cref="Id" />.</para>
            /// </summary>
            private class IdEncoder : enc.StructEncoder<Id>
            {
                /// <summary>
                /// <para>Encode fields of given value.</para>
                /// </summary>
                /// <param name="value">The value.</param>
                /// <param name="writer">The writer.</param>
                public override void EncodeFields(Id value, enc.IJsonWriter writer)
                {
                }
            }

            #endregion

            #region Decoder class

            /// <summary>
            /// <para>Decoder for  <see cref="Id" />.</para>
            /// </summary>
            private class IdDecoder : enc.StructDecoder<Id>
            {
                /// <summary>
                /// <para>Create a new instance of type <see cref="Id" />.</para>
                /// </summary>
                /// <returns>The struct instance.</returns>
                protected override Id Create()
                {
                    return Id.Instance;
                }

            }

            #endregion
        }

        /// <summary>
        /// <para>The other object</para>
        /// </summary>
        public sealed class Other : ListRevisionsMode
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
