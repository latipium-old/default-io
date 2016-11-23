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
        /// See File.Create
        /// </summary>
        /// <param name="path">Path.</param>
		[LatipiumMethod("Create")]
		public FileStream Create(string path) {
			if ( BeforeOperation(path) ) {
				try {
					return File.Create(path);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}

        /// <summary>
        /// See File.Create
        /// </summary>
        /// <param name="path">Path.</param>
        /// <param name="bufferSize">Buffer size.</param>
		[LatipiumMethod("Create")]
		public FileStream Create(string path, int bufferSize) {
			if ( BeforeOperation(path) ) {
				try {
					return File.Create(path, bufferSize);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}


        /// <summary>
        /// See File.Create
        /// </summary>
        /// <param name="path">Path.</param>
        /// <param name="bufferSize">Buffer size.</param>
        /// <param name="options">Options.</param>
		[LatipiumMethod("Create")]
		public FileStream Create(string path, int bufferSize, FileOptions options) {
			if ( BeforeOperation(path) ) {
				try {
					return File.Create(path, bufferSize, options);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}

        /// <summary>
        /// See File.Create
        /// </summary>
        /// <param name="path">Path.</param>
        /// <param name="bufferSize">Buffer size.</param>
        /// <param name="options">Options.</param>
        /// <param name="security">Security.</param>
		[LatipiumMethod("Create")]
		public FileStream Create(string path, int bufferSize, FileOptions options, FileSecurity security) {
			if ( BeforeOperation(path) ) {
				try {
					return File.Create(path, bufferSize, options, security);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}

        /// <summary>
        /// See File.CreateText
        /// </summary>
        /// <returns>The text.</returns>
        /// <param name="path">Path.</param>
		[LatipiumMethod("CreateText")]
		public StreamWriter CreateText(string path) {
			if ( BeforeOperation(path) ) {
				try {
					return File.CreateText(path);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}
	}
}

