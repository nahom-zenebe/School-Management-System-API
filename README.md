Features by Role
👨‍💼 Admin Features

Create/update/delete:

Students

Teachers

Classes

Subjects

Assign teachers to subjects

Assign students to classes

View reports:

Attendance summary

Grade performance

Manage users & roles

👩‍🏫 Teacher Features

View assigned classes & subjects

Mark student attendance

Submit grades

View class performance

Post announcements

🎓 Student Features

View personal profile

View class & subjects

View attendance history

View grades

Read announcements

🔐 Security Features

JWT authentication

Role-based authorization

Password hashing

Protected endpoints per role

🔄 Transaction-Critical Operations

Transactions ensure data consistency:

Feature	Why Transaction Needed
Mark Attendance	Attendance + student stats
Submit Grades	Grade + report update
Assign Teacher	Teacher + subject mapping
Enroll Student	User + student + class
🧠 Architecture Style (Recommended)
Controller → Service → Repository → Database
