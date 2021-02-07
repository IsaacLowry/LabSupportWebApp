// JavaScript source code
const UserCode = document.getElementById('UserCode')
const form = document.getElementById('form')
const errorElement = document.getElementById('error')

form.addEventListener('submit', (e) => {
    let messages = []
    if (UserCode.value === '' || UserCode.value == null) {
        messages.push("Please insert a user code to proceed")
    }


    if (UserCode.value === '123456') {
        messages.push('Please enter a unique code provided by a member of staff')
    } else if (UserCode.value.length != 6) {
        messages.push('Please enter 6 numbers')
    }
    else {
    }

    if (messages.length > 0) {
        e.preventDefault()
        errorElement.innerText = messages.join(',')
    }
    
})