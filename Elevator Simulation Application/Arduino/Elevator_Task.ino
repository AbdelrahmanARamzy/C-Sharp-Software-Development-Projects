//#include "Timer.h"
#include <Keypad.h>
# include <SoftwareSerial.h>

SoftwareSerial HH(10,13); //RX AND TX

int current1=0;
int current2=0;
int current3=0; 

int ChosenElev;

const byte interruptPin1 = 2;
const byte interruptPin2 = 3;


const byte ROWS = 4; //four rows
const byte COLS = 4; //four columns
char keys[ROWS][COLS] = {
  {'1','2','3','A'},
  {'4','5','6','B'},
  {'7','8','9','C'},
  {'*','0','#','D'}
};

byte rowPins[ROWS] = {5, 4, 12, 11}; //connect to the row pinouts of the keypad
byte colPins[COLS] = {9, 8, 7, 6}; //connect to the column pinouts of the keypad

Keypad keypad = Keypad( makeKeymap(keys), rowPins, colPins, ROWS, COLS );

void setup() {
 Serial.begin(9600);
 HH.begin (9600);
 
 pinMode(interruptPin1, INPUT_PULLUP);
 pinMode(interruptPin2, INPUT_PULLUP);

attachInterrupt(digitalPinToInterrupt(interruptPin1), find1,FALLING);
attachInterrupt(digitalPinToInterrupt(interruptPin2), find2, FALLING);
}

void loop() {
  char k = keypad.getKey();
  if(k){
    Serial.println(k);
  }
}
