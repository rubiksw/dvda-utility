# DVD-A Utility
Simple GUI for creating unencrypted DVD-A disks for playback on supported devices while preserving bit depth, sampling rate, and multiple audio channels.

Takes a folder of audio files and compresses them using the Meridian Lossless Packing (MLP) method. Creates an unencrypted DVD-A ISO which can be burned to a standard DVD-R / DVD-RW disk for playback on devices that support Packed PCM and muti-channel audio.

Uses ffmpeg for encoding, dvda-author for formatting the disk, and mkisofs for generating the ISO. You can burn the ISO using Windows and format as "Mastered Disk".

### Links
Meridian Lossless Packing (MLP) in a Nutshell -> http://www.hometheaterhifi.com/volume_8_4/dvd-benchmark-part-6-dvd-audio-11-2001.html#Meridian%20Lossless%20Packing%20(MLP)%20in%20a%20Nutshell

Supported audio formats -> https://ffmpeg.org/ffmpeg-formats.html

ffmpeg -> https://ffmpeg.org/about.html

dvda-author -> https://github.com/fabnicol/dvda-author

mkisofs -> https://wiki.osdev.org/Mkisofs
