# ADB-data-viewer
C# project that is capable of retrieving personal data (Contacts, Messages, Call Logs and Device info) from an
Android device connected via ADB. 

Following are the prerequisites before you execute the project :

1. adb shell content query --uri content://sms/ > smsinfo.txt
2. adb shell content query --uri content://contacts/phones/ > contactinfo.txt
3. adb shell cat /proc/cpuinfo > cpuinfo.txt
4. adb shell cat /proc/meminfo > meminfo.txt

After performing these commands, check the location of these files and in the Form1.cs file, update your path wherever required.
As soon as you run the application, you can see the extracted data in a formatted manner.
