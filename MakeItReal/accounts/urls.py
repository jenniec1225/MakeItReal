from django.urls import path
from . import views

urlpattens = [
    path('login/',views.login, name = 'login'),
]