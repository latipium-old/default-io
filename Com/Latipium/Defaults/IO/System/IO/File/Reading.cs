// Reading.cs
//
// Copyright (c) 2016 Zach Deibert.
// All Rights Reserved.
using System;
using System.IO;
using System.Text;
using Com.Latipium.Core;

namespace Com.Latipium.Defaults.IO {
	public partial class IOModule {
        /// <summary>
        /// See File.ReadAllBytes
        /// </summary>
        /// <returns>The all bytes.</returns>
        /// <param name="path">Path.</param>
		[LatipiumMethod("ReadAllBytes")]
		public byte[] ReadAllBytes(string path) {
			if ( BeforeOperation(path) ) {
				try {
					return File.ReadAllBytes(path);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}

        /// <summary>
        /// See File.ReadAllLines
        /// </summary>
        /// <returns>The all lines.</returns>
        /// <param name="path">Path.</param>
		[LatipiumMethod("ReadAllLines")]
		public string[] ReadAllLines(string path) {
			if ( BeforeOperation(path) ) {
				try {
					return File.ReadAllLines(path);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}

        /// <summary>
        /// See File.ReadAllLines
        /// </summary>
        /// <returns>The all lines.</returns>
        /// <param name="path">Path.</param>
        /// <param name="encoding">Encoding.</param>
		[LatipiumMethod("ReadAllLines")]
		public string[] ReadAllLines(string path, Encoding encoding) {
			if ( BeforeOperation(path) ) {
				try {
					return File.ReadAllLines(path, encoding);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}

        /// <summary>
        /// See File.ReadAllText
        /// </summary>
        /// <returns>The all text.</returns>
        /// <param name="path">Path.</param>
		[LatipiumMethod("ReadAllText")]
		public string ReadAllText(string path) {
			if ( BeforeOperation(path) ) {
				try {
					return File.ReadAllText(path);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}

        /// <summary>
        /// See File.ReadAllText
        /// </summary>
        /// <returns>The all text.</returns>
        /// <param name="path">Path.</param>
        /// <param name="encoding">Encoding.</param>
		[LatipiumMethod("ReadAllText")]
		public string ReadAllText(string path, Encoding encoding) {
			if ( BeforeOperation(path) ) {
				try {
					return File.ReadAllText(path, encoding);
				} finally {
					AfterOperation();
				}
			}
			return null;
		}
	}
}

