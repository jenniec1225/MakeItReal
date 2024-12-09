from django.urls import path
from MakeItReal.accounts.migrations import views

urlpattens = [
    path('login/',views.login, name = 'login'),
]