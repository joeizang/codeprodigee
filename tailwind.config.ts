import type { Config } from "tailwindcss";

const config: Config = {
  content: [
    "./src/pages/**/*.{js,ts,jsx,tsx,mdx}",
    "./src/components/**/*.{js,ts,jsx,tsx,mdx}",
    "./src/app/**/*.{js,ts,jsx,tsx,mdx}",
  ],
  theme: {
    extend: {
      colors: {
        'old-brick': {
          '50': '#fdf3f3',
          '100': '#fbe6e5',
          '200': '#f9d1cf',
          '300': '#f3b1ae',
          '400': '#ea837f',
          '500': '#de5a55',
          '600': '#ca3e38',
          '700': '#a9312c',
          '800': '#942e2a',
          '900': '#752a27',
          '950': '#3f1210',
      },
      'mountain-mist': {
          '50': '#f5f6f6',
          '100': '#e6e7e7',
          '200': '#cfd0d2',
          '300': '#aeb0b2',
          '400': '#939598',
          '500': '#6a6c70',
          '600': '#5b5c5f',
          '700': '#4d4e51',
          '800': '#444546',
          '900': '#3b3c3e',
          '950': '#252527',
      },
      'kabul': {
          '50': '#f5f4f1',
          '100': '#e6e1db',
          '200': '#cec4ba',
          '300': '#b1a293',
          '400': '#9b8574',
          '500': '#8c7566',
          '600': '#786056',
          '700': '#644f49',
          '800': '#54423f',
          '900': '#4a3b39',
          '950': '#291f1f',
      },
      'dust-storm': {
          '50': '#fbf6f5',
          '100': '#f7ece9',
          '200': '#f0ded8',
          '300': '#e5c6bc',
          '400': '#d4a495',
          '500': '#c28571',
          '600': '#ac6b56',
          '700': '#8f5846',
          '800': '#784b3c',
          '900': '#654237',
          '950': '#35211a',
      },    
      },
      backgroundImage: {
        "gradient-radial": "radial-gradient(var(--tw-gradient-stops))",
        "gradient-conic":
          "conic-gradient(from 180deg at 50% 50%, var(--tw-gradient-stops))",
      },
    },
  },
  plugins: [],
};
export default config;
