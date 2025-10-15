# 🏃‍♀️🏃‍♂️ Sport Reserve

**About the Project:**
Application for runners — search for interesting races, register for events, and manage your sports calendar.  

<img width="900" alt="sportreserve" src="https://github.com/user-attachments/assets/7c068a40-ea45-4dec-9af9-053579537eb9" />

Key features:
- Role-Based Access Control (RBAC) — simple and clear management of access and permissions for users, managers, and admins.
- Asynchronous email sending with RabbitMQ — a reliable system that makes sure every email gets delivered, even when the app is busy, without slowing it down.
- Modular microservices with a Shared package — common code is kept in one place, which makes Docker builds faster and easier.
- API Gateway as a proxy — one central point for all microservices, handling routing, security, and traffic control.
- Two databases for different needs — MSSQL for user and race data, MongoDB for reservations, giving better speed and flexibility.
- CI/CD and Docker Compose — automated build, test, and deployment to help release updates quickly and reliably.

The application is continuously developed, extended with new features, and regularly refactored to ensure the highest code quality and user experience.  

---

## ⚙️ Technology Stack

**Frontend:**  
- Angular  
- Angular Material  
- ngx-bootstrap  

**Backend (Microservices):**  
- ASP.NET Core (C#)  

**Databases:**  
- Microsoft SQL Server (MSSQL)  
- MongoDB

**Communication:**  
- REST API  
- RabbitMQ (for asynchronous email handling)  

**Containerization:**  
- Docker  
- Docker Compose  

**CI/CD:**  
- Custom pipelines for automating frontend builds and tests  

---

## 🧪 Testing

**Backend:**
- Unit tests written in **xUnit**

**Frontend:**  
- Unit tests written in **Jasmine**
- Run using **Karma test runner**

---

## 🚀 How to run the project with Docker Compose

1. Clone the repository using:  
   **git clone https://github.com/ArkadiuszSchabowski/SportReserve.git**  
2. Install Docker Desktop  
3. Navigate to the root of the project, where the **docker-compose.yml** file is located  
4. Start the application using: **docker-compose up**  

Once the last container is running, you can access the Angular application in your web browser at:  
**http://localhost:4200**

---

## 👥 Test User Accounts

**Test User Accounts** - To quickly test the application, you can use the following test user accounts:

User:
- Email: user@gmail.com
- Password: User123

Manager:
- Email: manager@gmail.com
- Password: Manager123

Admin:
- Email: admin@gmail.com
- Password: Admin123

---

## 📩 Contact

Questions or feedback? Feel free to contact me at: **arkadiuszschabowski@gmail.com**

---

**Sport Reserve** – Join a wonderful adventure with us and never miss any race. Stay fit and healthy.
