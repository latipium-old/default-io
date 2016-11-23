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
        /// <summary>
        /// See Directory.CreateDirectory
        /// </summary>
        /// <returns>The directory.</returns>
        /// <param name="path">Path.</param>
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
		
        /// <summary>
        /// See Directory.CreateDirectory
        /// </summary>
        /// <returns>The directory.</returns>
        /// <param name="path">Path.</param>
        /// <param name="directorySecurity">Directory security.</param>
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

