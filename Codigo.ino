const int LED = 2;

void setup() {
  Serial.begin(9600);
  pinMode(LED, OUTPUT);

}

void loop() {
  if(Serial.available()>0) {
    int input = Serial.read();
    if(input == 'A') {
      digitalWrite(LED, HIGH);  
    } else if (input == 'B') {
      digitalWrite(LED, LOW); 
    }
  }

}
