﻿// Decompiled with JetBrains decompiler
// Type: ADTree.My.Resources.Resources
// Assembly: ADTree, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: AD3D2372-2CAC-4221-B25D-8335DA876BAA
// Assembly location: \Source\mRemoteNG\mRemoteV1\References\ADTree.dll

using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ADTree.Resources
{
    [DebuggerNonUserCode]
    [CompilerGenerated]
    [GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
    internal sealed class Resources
    {
        private static ResourceManager _resourceMan;

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static ResourceManager ResourceManager =>
            _resourceMan ?? (_resourceMan = new ResourceManager("ADTree.Resources", typeof(Resources).Assembly));

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        internal static CultureInfo Culture { get; set; }

        internal static Bitmap Folder =>
            (Bitmap) RuntimeHelpers.GetObjectValue(ResourceManager.GetObject(nameof(Folder), Culture));

        internal static Bitmap Ou =>
            (Bitmap) RuntimeHelpers.GetObjectValue(ResourceManager.GetObject(nameof(Ou), Culture));

        internal static Bitmap Question =>
            (Bitmap) RuntimeHelpers.GetObjectValue(ResourceManager.GetObject(nameof(Question), Culture));

        internal static Bitmap Root =>
            (Bitmap) RuntimeHelpers.GetObjectValue(ResourceManager.GetObject(nameof(Root), Culture));
    }
}