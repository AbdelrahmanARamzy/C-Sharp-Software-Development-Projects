#include <Servo.h>

Servo serv1;
Servo serv2;
Servo serv3;

int servPos1 = 0;
int servPos2 = 0;
int servPos3 = 0; 

int SWTCH_1 = 8;
int SWTCH_2 = 9;
int SWTCH_3 = 10;
int SWTCH_4 = 11;

int buttonState = 0;
int buttonState2 = 0;
int buttonState3 = 0;
int buttonState4 = 0;

void setup() {
  Serial.begin(9600);

  serv1.attach(5);
  serv2.attach(6);
  serv3.attach(7);

  pinMode(SWTCH_1,INPUT);
  pinMode(SWTCH_2,INPUT);
  pinMode(SWTCH_3,INPUT);
  pinMode(SWTCH_4,INPUT);
}

void loop() {
  serv1.write(servPos1); 
  serv2.write(servPos2);
  serv3.write(servPos3);
  
  buttonState = digitalRead(SWTCH_1);
  buttonState2 = digitalRead(SWTCH_2);
  buttonState3 = digitalRead(SWTCH_3);
  buttonState4 = digitalRead(SWTCH_4);

/*///HARDWARE
//first finger
  if(buttonState > 0){
    servPos1=180;
    serv1.write(servPos1); 
  }
else {
  servPos1 = 0 ;
  serv1.write(servPos1);
  }
  
//second finger
  if(buttonState2 > 0){
    servPos2=180;
    serv2.write(servPos2); 
  }
else {
  servPos2 = 0 ;
  serv2.write(servPos2);
  }
  
//third finger
  if(buttonState3 > 0){
    servPos3=180;
    serv3.write(servPos3); 
  }
else {
  servPos3 = 0 ;
  serv3.write(servPos3);
  }
  
//SEQUENCE
  if(buttonState4 > 0){
    servPos1=180;
    serv1.write(servPos1);
    
    servPos2=180;
    serv2.write(servPos2);
    
    
    servPos1=90;
    serv1.write(servPos1);
     
    servPos2=90;
    serv2.write(servPos2);
  }
  else{
    servPos1 = 0 ;
    serv1.write(servPos1);
    
    servPos2 = 0 ;
    serv2.write(servPos2);
  }*/


///SOFTWARE
  if(buttonState > 0){
    Serial.println("1");

    servPos1=180;
    serv1.write(servPos1); 
  }
  else if(buttonState2 > 0){
        Serial.println("2");

        servPos2=180;
        serv2.write(servPos2); 
  }
  else if(buttonState3 > 0 ){
        Serial.println("3");
        
        servPos3=180;
        serv3.write(servPos3);
  }
  else if(buttonState4 > 0)
  {
    Serial.println("4");

    servPos1=180;
    serv1.write(servPos1);
     
    servPos2=180;
    serv2.write(servPos2);
    
    delay(1000);
    
    servPos1=90;
    serv1.write(servPos1); 
    
    servPos2=90;
    serv2.write(servPos2);

 
  }
  else
  {
    Serial.println("5");

    servPos1 = 0 ;
    serv1.write(servPos1);
  
    servPos2 = 0 ;
    serv2.write(servPos2);
  
    servPos3 = 0 ;
    serv3.write(servPos3);
  }
  delay(1000);
}
