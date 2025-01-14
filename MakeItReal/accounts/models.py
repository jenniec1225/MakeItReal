from django.db import models
from django.utils.timezone import now

# Create your models here.

class User(models.Model):
    username = models.CharField(max_length=150)
    email = models.EmailField(unique = True) #unique = 중복불가
    password = models.CharField(max_length = 128)
    date_joined = models.DateTimeField(default = now)
    is_active = models.BooleanField(default = True)


    def save(self, *args, **kwargs): #상속 관계에서 함수 재정의: method overriding 
        self.email = self.email.lower()
        if not self.date_joined:
            self.date_joined = now()
        super().save(*args, **kwargs)
