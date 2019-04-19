#include<Servo.h>

Servo motor[6];

Servo test;

int analogPin = A0;
int data;
int motorJoint = 48;//to take which joint to move
int angle;
int command;//read command in serial connection
int pos = 0;//servo motor loop movement variable
void setup() {
  // put your setup code here, to run once:
  motor[0].attach(8);
  motor[1].attach(9);
  motor[2].attach(10);
  motor[3].attach(11);
  motor[4].attach(12);
  motor[5].attach(13);
  Serial.begin(9600);

}

void motorMove(int i, int data)
{
  for(pos = 0; pos < data; pos += 1)  // goes from 0 degrees to 180 degrees 
 {                                  // in steps of 1 degree 
   motor[i].write(pos);              // tell servo to go to position in variable 'pos' 
   delay(35);                       // waits 15ms for the servo to reach the position 
 } 
 for(pos = data; pos>=1; pos-=1)     // goes from 180 degrees to 0 degrees 
 {                                
   motor[i].write(pos);              // tell servo to go to position in variable 'pos' 
   delay(35);                       // waits 15ms for the servo to reach the position 
 } 
}

void loop() {
  // put your main code here, to run repeatedly:
  delay(1);
  Serial.println("test");
  if(Serial.available())
  {
    command = Serial.read();
    
    switch(command)
    {
      case 113://ASCII code for q
      case 119:
      case 101:
      case 114:
      case 116:
              motorJoint = command;
              Serial.println(motorJoint);
              break;
      default:
              data = command;
              //to convert ASCII code to normal data
              switch(data)
              {
                case 48: data = 0;break;
                case 49: data = 1;break;
                case 50: data = 2;break;
                case 51: data = 3;break;
                case 52: data = 4;break;
                case 53: data = 5;break;
                case 54: data = 6;break;
                case 55: data = 7;break;
                case 56: data = 8;break;
                case 57: data = 9;break;
                default: break;   
              }
              //Serial.println(data);
              if (data>=0 && data <=9)
              switch(motorJoint)
              {
                case 113://code for base
                        if(data == 0)
                          //{motorMove(0,180);
                          //delay(500);}
                          motor[0].write(180);
                        else
                        //{motorMove(0, data*10*1.8);
                        //delay(500);}
                          motor[0].write(data*10*1.8);
                          Serial.println(data*10*1.8);
                        break;
                case 119:
                        if(data == 0)
                          motorMove(1, 180);
                        else
                        motorMove(1, data*10*1.8);
                         // motor[1].write(data*10*1.8);
                        //motor[2].write(data);
                        break;
                case 101:
                        if(data == 0)
                          motorMove(2, 180);
                        else
                          motorMove(2, data*10*1.8);
                        break;
                case 114:
                        if(data == 0)
                          motorMove(4, 180);
                        else
                          motorMove(4, data*10*1.8);
                        break;
                case 116:
                        if(data == 0)
                          motorMove(5,180);
                        else
                          motorMove(5, data*10*1.8);
                        break;
                default:
                        break;
              }
              break;
    }
    
  }
    
}

