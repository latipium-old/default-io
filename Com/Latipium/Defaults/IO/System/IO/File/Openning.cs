// Openning.cs
//
// Copyright (c) 2016 Zach Deibert.
// All Rights Reserved.
using System;
using System.IO;
using Com.Latipium.Core;

namespace Com.Latipium.Defaults.IO {
	public partial class IOModule {
        /// <summary>
        /// See File.Open
        /// </summary>
        /// <param name="path">Path.</param>
        /// <param name="mode">Mode.</param>
		[LatipiumMethod("Open")]
		public FileStream Open(string path, FileMode mode) {
			if ( BeforeOperation(path) ) {
				try {
					return File.Open(path, mode);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}

        /// <summary>
        /// See File.Open
        /// </summary>
        /// <param name="path">Path.</param>
        /// <param name="mode">Mode.</param>
        /// <param name="access">Access.</param>
		[LatipiumMethod("Open")]
		public FileStream Open(string path, FileMode mode, FileAccess access) {
			if ( BeforeOperation(path) ) {
				try {
					return File.Open(path, mode, access);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}

        /// <summary>
        /// See File.Open
        /// </summary>
        /// <param name="path">Path.</param>
        /// <param name="mode">Mode.</param>
        /// <param name="access">Access.</param>
        /// <param name="share">Share.</param>
		[LatipiumMethod("Open")]
		public FileStream Open(string path, FileMode mode, FileAccess access, FileShare share) {
			if ( BeforeOperation(path) ) {
				try {
					return File.Open(path, mode, access, share);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}

        /// <summary>
        /// See File.OpenRead
        /// </summary>
        /// <returns>The read.</returns>
        /// <param name="path">Path.</param>
		[LatipiumMethod("OpenRead")]
		public FileStream OpenRead(string path) {
			if ( BeforeOperation(path) ) {
				try {
					return File.OpenRead(path);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}

        /// <summary>
        /// See File.OpenText
        /// </summary>
        /// <returns>The text.</returns>
        /// <param name="path">Path.</param>
		[LatipiumMethod("OpenText")]
		public StreamReader OpenText(string path) {
			if ( BeforeOperation(path) ) {
				try {
					return File.OpenText(path);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}

        /// <summary>
        /// See File.OpenWrite
        /// </summary>
        /// <returns>The write.</returns>
        /// <param name="path">Path.</param>
		[LatipiumMethod("OpenWrite")]
		public FileStream OpenWrite(string path) {
			if ( BeforeOperation(path) ) {
				try {
					return File.OpenWrite(path);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}
	}
}

