﻿//
// RecipientProperties.cs
//
// Author: RecipientRowDisplayType and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NON INFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
//

using System.IO;
using MsgKit.Structures;
using OpenMcdf;

namespace MsgKit.Streams;

/// <summary>
///     The properties stream contained inside a recipient storage object.
/// </summary>
internal sealed class RecipientProperties : Properties
{
    #region Constructors
    /// <summary>
    ///     Creates this object
    /// </summary>
    internal RecipientProperties()
    {
    }

    /// <summary>
    ///     Creates this object and reads all the <see cref="Property">properties</see> 
    ///     from the given <see cref="CfbStream"/>
    /// </summary>
    /// <param name="stream">The <see cref="CfbStream"/></param>
    internal RecipientProperties(CfbStream stream)
    {
        using var binaryReader = new BinaryReader(stream);
        binaryReader.ReadBytes(8);
        ReadProperties(binaryReader);
    }
    #endregion

    #region WriteProperties
    /// <summary>
    ///     Writes all <see cref="Property">properties</see> either as a <see cref="CfbStream"/> or as a collection in
    ///     a <see cref="PropertyTags.PropertiesStreamName"/> stream to the given storage, this depends 
    ///     on the <see cref="Enums.PropertyType"/>
    /// </summary>
    /// <remarks>
    ///     See the <see cref="Properties"/> class it's <see cref="Properties.WriteProperties"/> method for the logic
    ///     that is used to determine this
    /// </remarks>
    /// <param name="storage">The <see cref="OpenMcdf.Storage"/></param>
    /// <returns>
    ///     Total size of the written <see cref="Properties"/>
    /// </returns>
    internal long WriteProperties(Storage storage)
    {
        using var memoryStream = new MemoryStream();
        using var binaryWriter = new BinaryWriter(memoryStream);
        // Reserved (8 bytes): This field MUST be set to zero when writing a .msg file and MUST be ignored when reading a .msg file.
        binaryWriter.Write(new byte[8]);
        return WriteProperties(storage, binaryWriter);
    }
    #endregion
}