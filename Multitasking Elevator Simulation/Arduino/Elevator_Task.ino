//#include "Timer.h"
#include <Keypad.h>
# include <SoftwareSerial.h>

SoftwareSerial HH(10,13); //RX AND TX
//Timer t;

String userCurrent;

int current1=0;
int current2=0;
int current3=0; 

int ChosenElev;

const byte interruptPin1 = 2;
const byte interruptPin2 = 3;

/*bool goingUp1= false;
bool goingDown1= false;

bool goingUp2= false;
bool goingDown2= false;

bool goingUp3= false;
bool goingDown3= false;*/


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

/*void elevator1 ()
{

if (elev1<5 && state1==true)
{
elev1=elev1+1;
current1=elev1;
//HH.println (elev1);
Serial.println ("elevator1 is going up ");
Serial.println (elev1);}
if (elev1==5){
  state1=false;}
if (elev1<=5&& state1 == false && elev1 !=1){

elev1=elev1-1;
//HH.println (elev1);
current1=-elev1;
Serial.println ("elevator1 is going down ");
Serial.println (elev1);
}
if(elev1==1){
state1 ==true;}
}
void elevator2 ()
{ 
//int elev2=1;
if (elev2<5 && state2==true)
{
elev2=elev2+1;
current2=elev2;
//HH.println (elev2);
Serial.println ("elevator2 is going up ");
Serial.println (elev2);}
if (elev2==5){
  state2=false;}
if (elev2<=5&& state2 == false && elev2 !=1){

elev2=elev2-1;
current2=-elev2;
Serial.println ("elevator2 is going down ");
Serial.println (elev2);}
//HH.println  (elev2);}
//if (elev2<=5&& state2 == false ){
//  if(elev2 !=1)
//  {
//
//elev2=elev2-1;
//current2=-elev2;
//Serial.println ("elevator2 is going down ");
//Serial.println (elev2);
//}
////}

else if(elev2==1){
state2== true;
    }
   }




void elevator3 ()
{ 
//Int elev3=1;
if (elev3<5 && state3==true)
{
elev3=elev3+1;
current3=elev3;
Serial.println ("elevator3 is going up ");
Serial.println (elev3);
//HH.println (elev3);
if (elev3==5){
  state3=false;}
if (elev3<=5&& state3 == false && elev3 !=1){

elev3=elev3-1;
current3=-elev3;
Serial.println ("elevator3 is going down ");
Serial.println (elev3);
//HH.println (elev3);
}
if(elev3==1){
state3 ==true;}
}
}*/




void setup() {
 Serial.begin(9600);
 HH.begin (9600);
 
 pinMode(interruptPin1, INPUT_PULLUP);
 pinMode(interruptPin2, INPUT_PULLUP);

//t.every(3000, elevator1);
//t.every(4000, elevator2);
//t.every(5000, elevator3);

attachInterrupt(digitalPinToInterrupt(interruptPin1), find1,FALLING);
attachInterrupt(digitalPinToInterrupt(interruptPin2), find2, FALLING);
}

int find1(char key){

int elevNum;

HH.println ("up"); 

int x=0 ;
int y=0;
int z=0; 

x= key - current1 ;
y= key - current2 ;
z= key - current3 ;

/*if   (x<y && x<z && x>=0)
//Serial.println ("choose  1 ");
ChosenElev = 1;
else if (y<x && y<z && y>=0)
//Serial.println ("choose  2 ");
ChosenElev = 2;
else if (z>y && z>x && z>=0)
//Serial.println ("choose  3 ");
ChosenElev = 3;
else if (x<y && x<z && x<0)
//Serial.println ("choose  1 ");
ChosenElev = 1;
else if (y<x && y<z && y<0)
//Serial.println ("choose  2 ");
ChosenElev = 2;
else if (z<y && z<x && z<0)
//Serial.println ("choose  3 ");
ChosenElev = 3;

}*/

if   ((x<y && x<z && x>=0) || (x<y && x<z && x<0)){
  //Serial.println ("choose  1 ");
elevNum = 1;
}

else if ((y<x && y<z && y>=0) || (y<x && y<z && y<0)){
  //Serial.println ("choose  2 ");
elevNum = 2;
}
else if ((z>y && z>x && z>=0) || (z<y && z<x && z<0)){
  //Serial.println ("choose  3 ");
elevNum = 3;
}

return elevNum;
}

int find2(char key){

int elevNum;
  
HH.println ("down");

int x=0 ;
int y=0;
int z=0; 

x= (-key) - current1 ;
y= (-key) - current2 ;
z= (-key) - current3 ;

/*if   (x<y && x<z && x>=0)
Serial.println ("choose  1 ");
else if (y<x && y<z && y>=0)
Serial.println ("choose  2 ");
else if (z>y && z>x && z>=0)
Serial.println ("choose  3 ");
else if (x<y && x<z && x<0)
Serial.println ("choose  1 ");
else if (y<x && y<z && y<0)
Serial.println ("choose  2 ");
else if (z<y && z<x && z<0)
Serial.println ("choose  3 ");*/

if   ((x<y && x<z && x>=0) || (x<y && x<z && x<0)){
  //Serial.println ("choose  1 ");
elevNum = 1;
}

else if ((y<x && y<z && y>=0) || (y<x && y<z && y<0)){
  //Serial.println ("choose  2 ");
elevNum = 2;
}
else if ((z>y && z>x && z>=0) || (z<y && z<x && z<0)){
  //Serial.println ("choose  3 ");
elevNum = 3;
}

return elevNum;
}


void loop() {
//  t.update();
  char k = keypad.getKey();
  //Serial.println(k);
  
  //delay(500);
  //checkKeyPad(k);
    
  if(k){
    Serial.println(k);
    //HH.println(k);
  }

  /*if (Serial.available()>0)
  { 
    data=Serial.read();
    Serial.println(data);
  }*/

}
 
void checkKeyPad(char key1){
  
String elevData;

 switch (key1){
  case 1:
                 userCurrent="1";
                 ChosenElev = find1 (key1);
                 elevData = userCurrent.concat(ChosenElev);
                 Serial.println(elevData);
                 break;
  case 2:
                 userCurrent="2";
                 ChosenElev = find1 (key1);
                 elevData = userCurrent.concat(ChosenElev);
                 Serial.println(elevData);
                 break;
  case 3:
                 userCurrent="2";
                 ChosenElev = find2 (key1);
                 elevData = userCurrent.concat(ChosenElev);
                 Serial.println(elevData);
                 break;
  case 4:
                 userCurrent="3";
                 ChosenElev = find1 (key1);
                 elevData = userCurrent.concat(ChosenElev);
                 Serial.println(elevData);
                 break;
  case 5:
                 userCurrent="3";
                 ChosenElev = find2 (key1);
                 elevData = userCurrent.concat(ChosenElev);
                 Serial.println(elevData);
                 break; 
  case 6:
                 userCurrent="4";
                 ChosenElev = find1 (key1);
                 elevData = userCurrent.concat(ChosenElev);
                 Serial.println(elevData);
                 break;
  case 7:
                 userCurrent="4";
                 ChosenElev = find2 (key1);
                 elevData = userCurrent.concat(ChosenElev);
                 Serial.println(elevData);
                 break; 
  case 8:
                 userCurrent="5";
                 ChosenElev =find1(key1) ;
                // String(ChosenElev);
                 elevData = userCurrent.concat(ChosenElev);
                 Serial.println(elevData);
                 break;
 }
}
