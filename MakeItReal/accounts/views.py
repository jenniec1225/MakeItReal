from django.shortcuts import render
from django.contrib.auth import authenticate, login
from .models import User

# Create your views here.
def login(request):
    return render(request, 'accounts/login.html')

def login_result(request):
    if request.method == 'POST':
        input_email = request.POST['email']
        input_password = request.POST['password']
        user = User.objects.filter(email = input_email)

        if user is not None:
            if user.model.password == input_password:
                return render(request, 'accounts/login.html')
            else:
                print('Invalid Password')
        else:
            print('Failed Login')
            return render(request, 'accounts/login.html')
    return render(request, 'accounts/login.html')

def register(request):
    return render(request, 'accounts/register.html')

def register_result(request):
    if request.method == 'POST':
        input_username = request.POST['username']
        input_email = request.POST['email']
        input_password = request.POST['password1']
        input_password_confirm = request.POST['password2']

        print(input_username)
        print(input_email)
        print(input_password)
        print(input_password_confirm)

        user = User.objects.create(
            username = input_username,
            email = input_email,
            password = input_password,
            is_active = True
        )
        user.save()

    return render(request, ' accounts/register.html')
