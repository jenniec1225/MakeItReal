from django.urls import path
from . import views

urlpatterns = [
    path('login/',views.login, name = 'login'),
    path('login_result/', views.login_result,name='login_result'),
    path('register/', views.register, name = 'register'),
    path('register_result/', views.register_result, name = 'register_result'),
]
