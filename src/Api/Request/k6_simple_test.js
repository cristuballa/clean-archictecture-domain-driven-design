import http from 'k6/http';
import { sleep } from 'k6';

export let options={
    insecureSkipTLSVerify: true,
    notConnectionReuse: false,
    vus:10,
    duration: '10s',
}

export default function () {
  const url = 'http://localhost:5236/auth/login';
  const payload = JSON.stringify({
    "email": "email@email.com",
    "password": "password123",
  });

  const params = {
    headers: {
      'Content-Type': 'application/json',
    },
  };

  http.post(url, payload, params);
  sleep(1);
}