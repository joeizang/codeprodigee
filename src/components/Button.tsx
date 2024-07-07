import React from 'react'

export interface ButtonProps {
  buttonText: string | (() => JSX.Element)
  specificStyle: string
}

export default function Button ({ buttonText, specificStyle, ...props }: ButtonProps) {
  return (
    <button
      className={specificStyle}
      {...props}
    >
      {typeof buttonText === 'string' ? buttonText : buttonText()}
    </button>
  )
}