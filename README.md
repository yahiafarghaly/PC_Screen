# PC_Screen
A C# application for displaying the data sent to your machine via UART Protocal

It is used for displaying data instead of using real LCD hardware when displaying data coming from MicroController.

I used it with atmel AVR microcontroller to debug my applications via UART protocal. To be able to send data from AVR
without worrying about UART driver. You can use my [abstracted APIs](https://github.com/yahiafarghaly/AVR_Drivers/tree/master/PC_Screen) for that


[Demo video of the software](https://www.youtube.com/watch?v=lFj07h4J7v4&feature=youtu.be)


### Constrains 

- Baud Rate: 9600
- stopbits: 1
- parity: none
