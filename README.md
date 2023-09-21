# Design-Patterns-Adapter

### The Adapter Design Pattern, also known as the Wrapper, allows two classes to work together that would otherwise have incompatible interfaces. For example, most mobile devices today can be powered via USB power, or via AC current. However, in both cases there is no direct way for the device to plug into the wall or USB port. The solution is an adapter.
### The pattern is particularly useful when integrating new classes or components into an existing system without changing the main application code.

### In this example, we have a notification system. The application can send out notifications to its users using email, SMS or a toast notification.
### Each one of these notification senders has a different interface:
### •	the EmailSender requires a 'from' and 'to' address, a subject, and a body
### •	the SmsSender requires a phone number and a message
### •	the ToastNotificationSender requires a username and a message

### The sample program generates an array of ten users, then sends out the notification 'Hello!' to each user, using all three available options. The problem with the current system is that in order to use it, we need to write complex client code that requires knowledge of how to work with all of these different sender classes. Additionally, if we need to add a new kind of notification, for example, an instant-messaging solution like the Facebook Messenger, we'd have to make some big changes to the client code. This violates the Open/Closed Principle, which states that a system should be open for extension, but closed for modification.

### We are going to implement the Adapter pattern to make the system more flexible & easier to use, while keeping the legacy classes intact.

### What are we going to learn?
### •	Implement the adapter pattern
