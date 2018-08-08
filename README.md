# MicroFormat
A simple Windows tool that can format USB or physical volumes to either NTFS or FAT32. It supports custom Volume names and quick formatting. Done out of boredom and curiosity for practicing purposes.

### Sanity Checks
There are sanity checks in the program. 
* The program will refuse to format the Windows partition. Because the Windows partition is not always C, the check is not hard-coded. Rather, I perform a comparison between the currently selected volume to format and the known System volume. If they match, I trip a flag.
* Volume Label sanity checks are also in place. These are necessary because NTFS volumes can hold a maximum of 32 characters with no tabs, and FAT32 volumes a maximum of 11 characters with no tabs and no `* ? . , ; : / \ | + = < > [ ]`.
* There are checks in place to prevent accidental formatting (You get asked whether you really want to format the volume).

### Screenshot
<p align="center">
  <img src="https://user-images.githubusercontent.com/15067741/43862690-5dc745c4-9b28-11e8-9217-b5b6e6b23e54.PNG"/>
</p>

### WARNUNG

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.

TLDR: If you break your devices, lose data, set your computer on fire, die, trigger WW3, or anything else by using this software, don't blame me. I am not liable. No warranty and no support will be given or should be expected.

### Contact me
* Twitter: https://twitter.com/FCE365
* WWW: https://fce365.info
* YouTube: https://youtube.com/fce365official
