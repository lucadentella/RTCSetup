#include <Wire.h>
#include "RTClib.h"

#define BUFFER_SIZE 20
#define VERSION     "1.0"

// RTC object
RTC_DS1307 RTC;

// Buffer for incoming data
char serial_buffer[BUFFER_SIZE];
int buffer_position;

void setup() {
  
  Serial.begin(57600);
  Wire.begin();
  RTC.begin();
  
  buffer_position = 0;
}

void loop() {
  
  // Wait for incoming data on serial port
  if (Serial.available() > 0) {
    
    // Read the incoming character
    char incoming_char = Serial.read();
    
    // End of line?
    if(incoming_char == '\n') {
      
      // Parse the command
      
      // ## 
      if(serial_buffer[0] == '#' && serial_buffer[1] == '#')
        Serial.println("!!");
        
      // ?V
      else if(serial_buffer[0] == '?' && serial_buffer[1] == 'V')
        Serial.println(VERSION);

      // ?T 
      else if(serial_buffer[0] == '?' && serial_buffer[1] == 'T') {        
        DateTime now = RTC.now();
        char time_string[20];
        sprintf(time_string, "%02d/%02d/%d %02d:%02d:%02d", 
          now.day(), now.month(), now.year(),
          now.hour(), now.minute(), now.second());
          Serial.println(time_string);
      }

      // !T 
      else if(serial_buffer[0] == '!' && serial_buffer[1] == 'T') {

        String time_string = String(serial_buffer);
        int day = time_string.substring(2, 4).toInt();
        int month = time_string.substring(4, 6).toInt();        
        int year = time_string.substring(6, 10).toInt();
        int hour = time_string.substring(10, 12).toInt();
        int minute = time_string.substring(12, 14).toInt();
        int second = time_string.substring(14, 16).toInt();
        DateTime set_time = DateTime(year, month, day, hour, minute, second);
        RTC.adjust(set_time);
        Serial.println("OK");
      }
      
      // Reset the buffer
      buffer_position = 0;
    }
    
    // Carriage return, do nothing
    else if(incoming_char == '\r');
    
    // Normal character
    else {
      
      // Buffer full, we need to reset it
      if(buffer_position == BUFFER_SIZE - 1) buffer_position = 0;

      // Store the character in the buffer and move the index
      serial_buffer[buffer_position] = incoming_char;
      buffer_position++;      
    }
  }    
}
