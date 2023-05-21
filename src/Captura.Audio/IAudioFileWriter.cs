using System;

namespace Captura.Audio
{
    /// Encodes Audio into an audio file.
    public interface IAudioFileWriter : IDisposable
    {
        /// Writes to file.
        void Write(byte[] Data, int Offset, int Count);

        /// Writes all buffered data to file.
        void Flush();
    }
}
