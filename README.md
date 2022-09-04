# DVD-A Utility
Create unencrypted DVD-A disks for playback on supported devices while preserving bit depth, sampling rate, and multiple audio channels. 

Takes a folder of audio files and compresses them using the Meridian Lossless Packing (MLP) method. Creates an unencrypted DVD-A ISO which can be burned to a standard DVD-R / DVD-RW disk for playback on devices that support Packed PCM and muti-channel audio.

Uses ffmpeg for encoding, dvda-author for formatting the disk, and mkisofs for generating the ISO. Burn the ISO using Windows and format as "Mastered Disk".
