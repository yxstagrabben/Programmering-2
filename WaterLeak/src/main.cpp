#include <Arduino.h>

#define SensorSignal 4
#define SensorPower 5

int sensorValue = 0;
int tempValue = 0;
int minCounter = 0;
int securityCounter = 0;
const int unReasonableValue = 10;

void setup() {
  Serial.begin(9600);
  pinMode(SensorPower, OUTPUT);
  digitalWrite(SensorPower, LOW);
}

void loop() {
  
  sensorValue = sensorRead();
  if(sensorValue > unReasonableValue)
  {
    securityCounter =+ 1;
    if(securityCounter = 1){
      minCounter = 0;
    }
    if(securityCounter = 3)
    {
      Serial.println("WaterLeak!! Level: " + sensorValue);
    }
  }
  else{
      Serial.println("WaterValue: " + sensorValue);
  }
  if(minCounter = 3)
  {
    minCounter = 0;
    securityCounter = 0;
  }
  minCounter =+ 1;
  delay(20000);
}
    
int sensorRead()
{
  pinMode(SensorPower,HIGH);
  delay(10);
  tempValue = analogRead(SensorSignal);
  digitalWrite(SensorPower, LOW);
  return(tempValue);
}