// Creating.cs
//
// Copyright (c) 2016 Zach Deibert.
// All Rights Reserved.
using System;
using System.IO;
using System.Security.AccessControl;
using Com.Latipium.Core;

namespace Com.Latipium.Defaults.IO {
	public partial class IOModule {
		[LatipiumMethod("CreateDirectory")]
		public DirectoryInfo CreateDirectory(string path) {
			if ( BeforeOperation(path) ) {
				try {
					return Directory.CreateDirectory(path);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}
		
		[LatipiumMethod("CreateDirectory")]
		public DirectoryInfo CreateDirectory(string path, DirectorySecurity directorySecurity) {
			if ( BeforeOperation(path) ) {
				try {
					return Directory.CreateDirectory(path, directorySecurity);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}
	}
}

